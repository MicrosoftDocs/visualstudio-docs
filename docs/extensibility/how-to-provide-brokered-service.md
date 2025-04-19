---
title: 'Provide a brokered service'
description: Learn how to design, create, register, and proffer a brokered service for consumption by yourself and others.
monikerRange: '>= vs-2019'
ms.date: 08/02/2024
ms.topic: how-to
helpviewer_keywords:
- brokered services, providing
author: aarnott
ms.author: andarno
manager: ansonh
ms.subservice: extensibility-integration
---
# Provide a brokered service

A brokered service consists of the following elements:

- [An interface](#ServiceInterface) that declares the service's functionality and serves as a contract between the service and its clients.
- [An implementation](#ServiceImplementation) of that interface.
- [A service moniker](#ServiceMoniker) to assign a name and a version to the service.
- [A descriptor](#ServiceRpcDescriptor) that combines the service moniker with behavior for handling RPC (Remote Procedure Call) when necessary.
- Either [proffer the service factory](#ProfferService) and [register](#ServiceRegistration) your brokered service with a VS package, or do [both with MEF](#MEF) (the Managed Extensibility Framework).

Each of the items in the preceding list are described in detail in the following sections.

With all code in this article, activating C#'s [nullable reference types](/dotnet/csharp/nullable-references) feature is highly recommended.

## <a name="ServiceInterface"></a> The service interface

The service interface may be a standard .NET interface (often written in C#), but should conform to the guidelines set by the <xref:Microsoft.ServiceHub.Framework.ServiceRpcDescriptor>-derived type that your service will use to ensure the interface can be used over RPC when the client and service run in different processes.
These restrictions typically include that properties and indexers are not allowed, and most or all methods return `Task` or another async-compatible return type.

The <xref:Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor> is the recommended derived type for brokered services.
This class utilizes the <xref:StreamJsonRpc> library when the client and service require RPC to communicate.
StreamJsonRpc applies certain restrictions on the service interface as [described here](https://github.com/microsoft/vs-streamjsonrpc/blob/main/doc/dynamicproxy.md).

The interface *may* derive from <xref:System.IDisposable>, <xref:System.IAsyncDisposable?displayProperty=fullName>, or even <xref:Microsoft.VisualStudio.Threading.IAsyncDisposable?displayProperty=fullName> but this is not required by the system.
The generated client proxies will implement <xref:System.IDisposable> either way.

A simple calculator service interface may be declared like this:

```csharp
public interface ICalculator
{
    ValueTask<double> AddAsync(double a, double b, CancellationToken cancellationToken);
    ValueTask<double> SubtractAsync(double a, double b, CancellationToken cancellationToken);
}
```

Although the implementation of the methods on this interface may not warrant an async method, we always use async method signatures on this interface because this interface is used to generate the client proxy that may invoke this service remotely, which certainly *does* warrant an async method signature.

An interface may declare events that can be used to notify their clients of events occurring at the service.

<a name="ClientRpcTarget"></a>
Beyond events or the observer design pattern, a brokered service that needs to "call back" to the client may define a second interface that serves as the contract that a client must implement and provide via the <xref:Microsoft.ServiceHub.Framework.ServiceActivationOptions.ClientRpcTarget?displayProperty=nameWithType> property when requesting the service.
Such an interface should conform to all the same design patterns and restrictions as the brokered service interface, but with added restrictions on versioning.

Review [Best Practices for Designing a Brokered Service](best-practices-design-brokered-service.md) for tips on designing a performant, future-proof RPC interface.

It can be useful to declare this interface in a distinct assembly from the assembly that implements the service so that its clients can reference the interface without the service having to expose more of its implementation detail.
It may also be useful to ship the interface assembly as a NuGet package for other extensions to reference while reserving your own extension to ship the service implementation.

Consider targeting the assembly that declares your service interface to `netstandard2.0` to ensure your service may be easily invoked from any .NET process whether it is running .NET Framework, .NET Core, .NET 5 or later.

### Testing

Automated tests should be written alongside your service *interface* to verify the interface's RPC readiness.

The tests should verify that all data passed through the interface are serializable.

You may find the <xref:Microsoft.VisualStudio.Sdk.TestFramework.BrokeredServiceContractTestBase%602> class from the [Microsoft.VisualStudio.Sdk.TestFramework.Xunit](https://www.nuget.org/packages/microsoft.visualstudio.sdk.testframework.xunit) package useful to derive your interface test class from.
This class includes some basic convention testing for your interface, methods to assist with common assertions like event testing, and more.

#### Methods

Assert that every argument and the return value were serialized completely.
If you are using the test base class mentioned above, your code might look like this:

```csharp
public interface IYourService
{
    Task<bool> SomeOperationAsync(YourStruct arg1);
}

public static class Descriptors
{
    public static readonly ServiceRpcDescriptor YourService = new ServiceJsonRpcDescriptor(
        new ServiceMoniker("YourCompany.YourExtension.YourService", new Version(1, 0)),
        clientInterface: null,
        ServiceJsonRpcDescriptor.Formatters.MessagePack,
        ServiceJsonRpcDescriptor.MessageDelimiters.BigEndianInt32LengthHeader,
        new MultiplexingStream.Options { ProtocolMajorVersion = 3 })
        .WithExceptionStrategy(StreamJsonRpc.ExceptionProcessing.ISerializable);
}

public class YourServiceMock : IYourService
{
    internal YourStruct? SomeOperationArg1 { get; set; }

    public Task<bool> SomeOperationAsync(YourStruct arg1, CancellationToken cancellationToken)
    {
        this.SomeOperationArg1 = arg1;
        return true;
    }
}

public class BrokeredServiceTests : BrokeredServiceContractTestBase<IYourService, YourServiceMock>
{
    public BrokeredServiceTests(ITestOutputHelper logger)
        : base(logger, Descriptors.YourService)
    {
    }

    [Fact]
    public async Task SomeOperation()
    {
        var arg1 = new YourStruct
        {
            Field1 = "Something",
        };
        Assert.True(await this.ClientProxy.SomeOperationAsync(arg1, this.TimeoutToken));
        Assert.Equal(arg1.Field1, this.Service.SomeOperationArg1.Value.Field1);
    }
}
```

Consider testing overload resolution if you declare multiple methods with the same name.
You might add an `internal` field to your mock service for each method on it that stores arguments for that method so the test method can call the method and then verify that the right method was invoked with the right arguments.

#### Events

Any events declared on your interface should be tested for RPC readiness too.
Events raised from a brokered service do *not* cause a test failure if they fail during RPC serialization because events are "fire and forget".

If you are using the test base class mentioned above this behavior is already built into some helper methods and  might look like this (with unchanged parts omitted for brevity):

```cs
public interface IYourService
{
    event EventHandler<int> NewTotal;
}

public class YourServiceMock : IYourService
{
    public event EventHandler<int>? NewTotal;

    internal void RaiseNewTotal(int arg) => this.NewTotal?.Invoke(this, arg);
}

public class BrokeredServiceTests : BrokeredServiceContractTestBase<IYourService, YourServiceMock>
{
    [Fact]
    public async Task NewTotal()
    {
        await this.AssertEventRaisedAsync<int>(
            (p, h) => p.NewTotal += h,
            (p, h) => p.NewTotal -= h,
            s => s.RaiseNewTotal(50),
            a => Assert.Equal(50, a));
    }
}
```

## <a name="ServiceImplementation"></a> Implementing the service

The service class should implement the RPC interface declared in the prior step.
A service may implement <xref:System.IDisposable> or any other interfaces beyond the one used for RPC.
The proxy generated on the client only implements the service interface, <xref:System.IDisposable>, and possibly a few other select interfaces to support the system, so a cast to other interfaces implemented by the service will fail on the client.

Consider the calculator example used above, which we implement here:

```csharp
internal class Calculator : ICalculator
{
    public ValueTask<double> AddAsync(double a, double b, CancellationToken cancellationToken)
    {
        return new ValueTask<double>(a + b);
    }

    public ValueTask<double> SubtractAsync(double a, double b, CancellationToken cancellationToken)
    {
        return new ValueTask<double>(a - b);
    }
}
```

Because the method bodies themselves don't need to be async, we explicitly wrap the return value in a constructed <xref:System.Threading.Tasks.ValueTask%601> return type to conform to the service interface.

### Implementing the observable design pattern

If you offer an observer subscription on your service interface, it might look like this:

```cs
Task<IDisposable> SubscribeAsync(IObserver<YourDataType> observer);
```

The <xref:System.IObserver%601> argument will typically need to outlive the lifetime of this method call so that the client can continue to receive updates after the method call completes until the client disposes of the returned <xref:System.IDisposable> value.
To facilitate this your service class may include a collection of <xref:System.IObserver%601> subscriptions that any updates made to your state would then enumerate to update all subscribers.
Be sure enumeration of your collection is thread-safe with respect to each other and especially with the mutations on that collection that may occur via additional subscriptions or disposals of those subscriptions.

Take care that all updates posted via <xref:System.IObserver%601.OnNext%2A> retain the order in which state changes were introduced to your service.

All subscriptions should ultimately be terminated with either a call to <xref:System.IObserver%601.OnCompleted%2A> or <xref:System.IObserver%601.OnError%2A> to avoid resource leaks on the client and RPC systems.
This includes on service disposal where all remaining subscriptions should be explicitly completed.

Learn more about [the observer design pattern](/dotnet/standard/events/observer-design-pattern), [how to implement an observable data provider](/dotnet/standard/events/how-to-implement-a-provider) and particularly [with RPC in mind](https://github.com/microsoft/vs-streamjsonrpc/blob/main/doc/observer.md).

### Disposable services

Your service class is not required to be disposable, but services that are will be disposed of when the client disposes their proxy to your service or the connection between client and service is lost.
Disposable interfaces are tested for in this order: <xref:System.IAsyncDisposable?displayProperty=fullName>, <xref:Microsoft.VisualStudio.Threading.IAsyncDisposable?displayProperty=fullName>, <xref:System.IDisposable>.
Only the first interface from this list that your service class implements will be used to dispose of the service.

Keep thread-safety in mind when considering disposal.
Your <xref:System.IDisposable.Dispose%2A> method may be called on any thread while other code in your service is running (for example, if a connection being dropped).

### Throwing exceptions

When throwing exceptions, consider throwing <xref:StreamJsonRpc.LocalRpcException> with a specific [ErrorCode](xref:StreamJsonRpc.LocalRpcException.ErrorCode) in order to control the error code received by the client in the <xref:StreamJsonRpc.RemoteInvocationException>.
Supplying clients with an error code can enable them to branch based on the nature of the error better than parsing exception messages or types.

Per the JSON-RPC spec, error codes MUST be greater than -32000, including positive numbers.

### Consuming other brokered services

When a brokered service itself requires access to another brokered service, we recommend use of the <xref:Microsoft.ServiceHub.Framework.IServiceBroker> that is provided to its service factory, but it is especially important when the brokered service registration sets the  <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ProvideBrokeredServiceAttribute.AllowTransitiveGuestClients> flag.

To conform to this guideline if our calculator service had need of other brokered services to implement its behavior, we would modify the constructor to accept an <xref:Microsoft.ServiceHub.Framework.IServiceBroker>:

```csharp
internal class Calculator : ICalculator
{
    private readonly State state;
    private readonly IServiceBroker serviceBroker;

    internal class Calculator(State state, IServiceBroker serviceBroker)
    {
        this.state = state;
        this.serviceBroker = serviceBroker;
    }

    // ...
}
```

Learn more about [how to secure a brokered service](how-to-secure-brokered-service.md) and [consuming brokered services](how-to-consume-brokered-service.md).

### Stateful services

#### Per-client state

A new instance of this class will be created for each client that requests the service.
A field on the `Calculator` class above would store a value that might be unique to each client.
Suppose we add a counter that increments every time an operation is performed:

```csharp
internal class Calculator : ICalculator
{
    int operationCounter;

    public ValueTask<double> AddAsync(double a, double b, CancellationToken cancellationToken)
    {
        this.operationCounter++;
        return new ValueTask<double>(a + b);
    }

    public ValueTask<double> SubtractAsync(double a, double b, CancellationToken cancellationToken)
    {
        this.operationCounter++;
        return new ValueTask<double>(a - b);
    }
}
```

Your brokered service should be written to follow thread-safe practices.
When using the recommended <xref:Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor>, remote connections with clients may include concurrent execution of your service's methods as described in [this document](https://github.com/microsoft/vs-streamjsonrpc/blob/main/doc/resiliency.md).
When the client shares a process and AppDomain with the service, the client might call your service concurrently from multiple threads.
A thread-safe implementation of the above example might use <xref:System.Threading.Interlocked.Increment(System.Int32@)?displayProperty=nameWithType> to increment the `operationCounter` field.

#### Shared state

If there is state that your service will need to share across all its clients, this state should be defined in a distinct class that is instantiated by your VS Package and passed in as an argument to your service's constructor.

Suppose we want the `operationCounter` defined above to count all operations across all clients of the service.
We would need to lift the field into this new state class:

```csharp
internal class Calculator : ICalculator
{
    private readonly State state;

    internal Calculator(State state)
    {
        this.state = state;
    }

    public ValueTask<double> AddAsync(double a, double b, CancellationToken cancellationToken)
    {
        this.state.IncrementCounter();
        return new ValueTask<double>(a + b);
    }

    public ValueTask<double> SubtractAsync(double a, double b, CancellationToken cancellationToken)
    {
        this.state.IncrementCounter();
        return new ValueTask<double>(a - b);
    }

    internal class State
    {
        private int operationCounter;

        internal int OperationCounter => this.operationCounter;

        internal void IncrementCounter() => Interlocked.Increment(ref this.operationCounter);
    }
}
```

Now we have an elegant, testable way to manage shared state across multiple instances of our `Calculator` service.
Later when writing the code to proffer the service we will see how this `State` class is created once and shared with every instance of the `Calculator` service.

It is especially important to be thread-safe when dealing with shared state because no assumption can be made around multiple clients scheduling their calls such that they are never made concurrently.

If your shared state class needs to access other brokered services, it should use the global service broker rather than one of the contextual ones assigned to an individual instance of your brokered service.
Using the global service broker within a brokered service carries with it [security implications](how-to-secure-brokered-service.md) when the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ProvideBrokeredServiceAttribute.AllowTransitiveGuestClients?displayProperty=nameWithType> flag is set.

### Security concerns

Security is a consideration for your brokered service if it is registered with the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ProvideBrokeredServiceAttribute.AllowTransitiveGuestClients?displayProperty=nameWithType> flag, which exposes it to possible access by other users on other machines that are participating in a shared Live Share session.

Review [How to Secure a Brokered Service](how-to-secure-brokered-service.md) and take the necessary security mitigations before setting the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ProvideBrokeredServiceAttribute.AllowTransitiveGuestClients> flag.

## <a name="ServiceMoniker"></a> The service moniker

A brokered service must have a serializable name and an optional version by which a client may request the service.
A <xref:Microsoft.ServiceHub.Framework.ServiceMoniker> is a convenient wrapper for these two pieces of information.

A service moniker is analogous to the assembly-qualified full name of a CLR (Common Language Runtime) type.
It must be globally unique and should therefore include your company name and perhaps your extension name as prefixes to the service name itself.

It may be useful to define this moniker in a `static readonly` field for use elsewhere:

```csharp
public static readonly ServiceMoniker Moniker = new ServiceMoniker("YourCompany.Extension.Calculator", new Version("1.0"));
```

While most uses of your service may not use your moniker directly, a client that communicates over pipes instead of a proxy will require the moniker.

While a version is optional on a moniker, providing a version is recommended as it gives service authors more options for maintaining compatibility
with clients across behavioral changes.

## <a name="ServiceRpcDescriptor"></a> The service descriptor

The service descriptor combines the service moniker with the behaviors required to run an RPC connection and create a local or remote proxy.
The descriptor is responsible to effectively convert your RPC interface into a wire protocol.
This service descriptor is an instance of a <xref:Microsoft.ServiceHub.Framework.ServiceRpcDescriptor>-derived type.
The descriptor must be made available to all clients that will use a proxy to access this service.
Proffering the service also requires this descriptor.

Visual Studio defines one such derived type and recommends its use for all services: <xref:Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor>.
This descriptor utilizes <xref:StreamJsonRpc> for its RPC connections and creates a high-performance local proxy for local services that emulates some of the remote behaviors such as wrapping exceptions thrown by the service in <xref:StreamJsonRpc.RemoteInvocationException>.

The <xref:Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor> supports configuring the <xref:StreamJsonRpc.JsonRpc> class for JSON or MessagePack encoding of the JSON-RPC protocol.
We recommend MessagePack encoding because it's more compact and can be 10X more performant.

We can define a descriptor for our calculator service like this:

```csharp
/// <summary>
/// The descriptor for the calculator brokered service.
/// Use the <see cref="ICalculator"/> interface for the client proxy for this service.
/// </summary>
public static readonly ServiceRpcDescriptor CalculatorService = new ServiceJsonRpcDescriptor(
    Moniker,
    Formatters.MessagePack,
    MessageDelimiters.BigEndianInt32LengthHeader,
    new MultiplexingStream.Options { ProtocolMajorVersion = 3 })
    .WithExceptionStrategy(StreamJsonRpc.ExceptionProcessing.ISerializable);
```

As you can see above, a choice of formatter and delimiter is available.
As not all combinations are valid, we recommend either of these combinations:

<xref:Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor.Formatters> | <xref:Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor.MessageDelimiters> | Best for
--|--|--
<xref:Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor.Formatters.MessagePack> | <xref:Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor.MessageDelimiters.BigEndianInt32LengthHeader> | High performance
<xref:Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor.Formatters.UTF8> (JSON) | <xref:Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor.MessageDelimiters.HttpLikeHeaders> | Interop with other JSON-RPC systems

By specifying the `MultiplexingStream.Options` object as the final parameter, the RPC connection shared between client and service is just one channel on a [MultiplexingStream](https://dotnet.github.io/Nerdbank.Streams/docs/MultiplexingStream.html), which is shared with the JSON-RPC connection to [enable efficient transfer of large binary data over JSON-RPC](https://github.com/microsoft/vs-streamjsonrpc/blob/main/doc/oob_streams.md).

The <xref:StreamJsonRpc.ExceptionProcessing.ISerializable?displayProperty=nameWithType> strategy causes exceptions thrown from your service to be serialized and preserved as the <xref:System.Exception.InnerException?displayProperty=nameWithType> to the <xref:StreamJsonRpc.RemoteInvocationException> thrown on the client.
Without this setting, less detailed exception information is available on the client.

Tip: Expose your descriptor as <xref:Microsoft.ServiceHub.Framework.ServiceRpcDescriptor> rather than any derived type you use as an implementation detail.
This gives you more flexibility to change implementation details later without API breaking changes.

Include a reference to your service interface in the xml doc comment on your descriptor to make it easier for users to consume your service.
Also reference the interface your service accepts as the client RPC target, if applicable.

Some more advanced services may also accept or require an RPC target object from the client that conforms to some interface.
For such a case, use a <xref:Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor.%23ctor%2A> constructor with a `Type clientInterface` parameter to specify the interface the client should supply an instance of.

### Versioning the descriptor

Over time you may want to increment the version of your service.
In such a case you should define a descriptor for each version you wish to support, using a unique version-specific <xref:Microsoft.ServiceHub.Framework.ServiceMoniker> for each one.
Supporting multiple versions simultaneously can be good for backward compatibility and can usually be done with just one RPC interface.

Visual Studio follows this pattern with its <xref:Microsoft.VisualStudio.VisualStudioServices> class by defining the original <xref:Microsoft.ServiceHub.Framework.ServiceRpcDescriptor> as a `virtual` property under the nested class that represents the first release that added that brokered service.
When we need to change the wire protocol or add/change functionality of the service, Visual Studio declares an `override` property in a later versioned nested class that returns a new <xref:Microsoft.ServiceHub.Framework.ServiceRpcDescriptor>.

For a service defined and proffered by a Visual Studio extension, it may suffice to declare another descriptor property next to the original.
For example suppose your 1.0 service used the UTF8 (JSON) formatter and you realize that switching to MessagePack would deliver a significant performance benefit.
As changing the formatter is a wire protocol-breaking change, it requires incrementing the brokered service version number and a second descriptor.
The two descriptors together might look like this:

```csharp
public static readonly ServiceJsonRpcDescriptor CalculatorService = new ServiceJsonRpcDescriptor(
    new ServiceMoniker("YourCompany.Extension.Calculator", new Version("1.0")),
    Formatters.UTF8,
    MessageDelimiters.HttpLikeHeaders,
    new MultiplexingStream.Options { ProtocolMajorVersion = 3 })
    );

public static readonly ServiceJsonRpcDescriptor CalculatorService1_1 = new ServiceJsonRpcDescriptor(
    new ServiceMoniker("YourCompany.Extension.Calculator", new Version("1.1")),
    Formatters.MessagePack,
    MessageDelimiters.BigEndianInt32LengthHeader,
    new MultiplexingStream.Options { ProtocolMajorVersion = 3 });
```

Although we declare two descriptors (and later we'll have to proffer and register two services) that we can do this with just one service interface and implementation, keeping overhead for supporting multiple service versions quite low.

## <a name="ProfferService"></a> Proffering the service

Your brokered service must be created when a request comes in, which is arranged via a step called proffering the service.

### The service factory

Use <xref:Microsoft.VisualStudio.Shell.ServiceProvider.GlobalProvider%2A>.<xref:Microsoft.VisualStudio.Shell.ServiceExtensions.GetServiceAsync%2A> to request the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.SVsBrokeredServiceContainer>.
Then call <xref:Microsoft.VisualStudio.Shell.ServiceBroker.IBrokeredServiceContainer.Proffer%2A?displayProperty=nameWithType> on that container to proffer your service.

In the example below, we proffer a service using the `CalculatorService` field declared earlier which is set to an instance of a <xref:Microsoft.ServiceHub.Framework.ServiceRpcDescriptor>.
We pass it our service factory, which is a <xref:Microsoft.VisualStudio.Shell.ServiceBroker.BrokeredServiceFactory> delegate.

```cs
IBrokeredServiceContainer container = await AsyncServiceProvider.GlobalProvider.GetServiceAsync<SVsBrokeredServiceContainer, IBrokeredServiceContainer>();
container.Proffer(
    CalculatorService,
    (moniker, options, serviceBroker, cancellationToken) => new ValueTask<object?>(new CalculatorService()));
```

A brokered service is typically instantiated once per client.
This is a departure from [other VS (Visual Studio) services](using-and-providing-services.md), which are typically instantiated once and shared across all clients.
Creating one instance of the service per client allows for better security as each service and/or its connection can retain per-client state about the authorization level the client operates at, what their preferred <xref:System.Globalization.CultureInfo> is, etc.
As we'll see next, it also allows for more interesting services that accept arguments specific to this request.

> [!IMPORTANT]
> A service factory that deviates from this guideline and returns a shared service instance instead of a new one to each client should *never* have its service implement <xref:System.IDisposable>, since the first client to dispose of its proxy will lead to disposal of the shared service instance before other clients are done using it.

In the more advanced case where the `CalculatorService` constructor requires a shared state object and an <xref:Microsoft.ServiceHub.Framework.IServiceBroker>, we might proffer the factory like this:

```csharp
var state = new CalculatorService.State();
container.Proffer(
    CalculatorService,
    (moniker, options, serviceBroker, cancellationToken) => new ValueTask<object?>(new CalculatorService(state, serviceBroker)));
```

The `state` local variable is *outside* the service factory and thus is created only once and shared across all instantiated services.

Still more advanced, if the service required access to the <xref:Microsoft.ServiceHub.Framework.ServiceActivationOptions> (for example, to invoke methods on the client RPC target object) that could be passed in as well:

```csharp
var state = new CalculatorService.State();
container.Proffer(CalculatorService, (moniker, options, serviceBroker, cancellationToken) =>
    new ValueTask<object?>(new CalculatorService(state, serviceBroker, options)));
```

In this case the service constructor might look like this, assuming the <xref:Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor> were created with `typeof(IClientCallbackInterface)` as one of its constructor arguments:

```csharp
internal class Calculator(State state, IServiceBroker serviceBroker, ServiceActivationOptions options)
{
    this.state = state;
    this.serviceBroker = serviceBroker;
    this.options = options;
    this.clientCallback = (IClientCallbackInterface)options.ClientRpcTarget;
}
```

This `clientCallback` field can now be invoked anytime the service wants to invoke the client, until the connection is disposed of.

The <xref:Microsoft.VisualStudio.Shell.ServiceBroker.BrokeredServiceFactory> delegate takes a <xref:Microsoft.ServiceHub.Framework.ServiceMoniker> as a parameter in case the service factory is a shared method that creates multiple services or distinct versions of the service based on the moniker.
This moniker comes from the client and includes the version of the service they expect.
By forwarding this moniker to the service constructor, the service may emulate the quirky behavior of particular service versions to match what the client may expect.

Avoid using the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.AuthorizingBrokeredServiceFactory> delegate with the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.IBrokeredServiceContainer.Proffer%2A?displayProperty=nameWithType> method unless you will use the <xref:Microsoft.ServiceHub.Framework.Services.IAuthorizationService> inside your brokered service class.
This <xref:Microsoft.ServiceHub.Framework.Services.IAuthorizationService> *must* be disposed of with your brokered service class to avoid a memory leak.

### Supporting multiple versions of your service

When you increment the version on your <xref:Microsoft.ServiceHub.Framework.ServiceMoniker>, you must proffer each version of your brokered service that you intend to respond to client requests for.
This is done by calling the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.IBrokeredServiceContainer.Proffer%2A?displayProperty=nameWithType> method with each <xref:Microsoft.ServiceHub.Framework.ServiceRpcDescriptor> that you still support.

Proffering your service with a `null` version will serve as a 'catch all' which will match on any client request for which a precise version match with a registered service does not exist.
For example you may proffer your 1.0 and 1.1 service with specific versions, and also register your service with a `null` version.
In such cases, clients requesting your service with 1.0 or 1.1 invokes the service factory you proffered for those exact versions, while a client requesting version 8.0 leads to your null-versioned proffered service factory being invoked.
Because the client requested version is provided to the service factory, the factory may then make a decision about how to configure the service for this particular client or whether to return `null` to signify an unsupported version.

A client request for a service with a `null` version *only* matches on a service registered and proffered with a `null` version.

Consider a case where you have published many versions of your service, several of which are backward compatible and thus may share a service implementation.
We can utilize the catch-all option to avoid having to repeatedly proffer each individual version as follows:

```cs
const string ServiceName = "YourCompany.Extension.Calculator";
ServiceRpcDescriptor CreateDescriptor(Version? version) =>
    new ServiceJsonRpcDescriptor(
        new ServiceMoniker(ServiceName, version),
        ServiceJsonRpcDescriptor.Formatters.MessagePack,
        ServiceJsonRpcDescriptor.MessageDelimiters.BigEndianInt32LengthHeader);

IBrokeredServiceContainer container = await AsyncServiceProvider.GlobalProvider.GetServiceAsync<SVsBrokeredServiceContainer, IBrokeredServiceContainer>();
container.Proffer(
    CreateDescriptor(new Version(2, 0)),
    (moniker, options, serviceBroker, cancellationToken) => new ValueTask<object?>(new CalculatorServiceV2()));
container.Proffer(
    CreateDescriptor(null), // proffer a catch-all
    (moniker, options, serviceBroker, cancellationToken) => new ValueTask<object?>(moniker.Version switch {
        { Major: 1 } => new CalculatorService(), // match any v1.x request with our v1 service.
        null => null, // We don't support clients that do not specify a version.
        _ => null, // The client requested some other version we don't recognize.
    }));
```

## <a name="ServiceRegistration"></a> Registering the service

Proffering a brokered service to the global brokered service container will throw unless the service has first been registered.
Registration provides a means for the container to know in advance which brokered services may be available and which VS Package to load when they are requested in order to execute the proffering code.
This allows Visual Studio to start up quickly, without loading all extensions in advance, yet be able to load the required extension when requested by a client of its brokered service.

Registration can be done by applying the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ProvideBrokeredServiceAttribute> to your <xref:Microsoft.VisualStudio.Shell.AsyncPackage>-derived class.
This is the only place where the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ServiceAudience> may be set.

```csharp
[ProvideBrokeredService("YourCompany.Extension.Calculator", "1.0", Audience = ServiceAudience.Local)]
```

The default <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ProvideBrokeredServiceAttribute.Audience> is <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ServiceAudience.Process?displayProperty=nameWithType>, which exposes your brokered service only to other code within the same process.
By setting <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ServiceAudience.Local?displayProperty=nameWithType>, you opt in to exposing your brokered service to other processes belonging to the same Visual Studio session.

If your brokered service *must* be exposed to Live Share guests, the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ProvideBrokeredServiceAttribute.Audience> must include <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ServiceAudience.LiveShareGuest?displayProperty=nameWithType> and the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ProvideBrokeredServiceAttribute.AllowTransitiveGuestClients?displayProperty=nameWithType> property set to `true`.
**Setting these flags can introduce serious security vulnerabilities** and shouldn't be done without first conforming to the guidance in [How to Secure a Brokered Service](how-to-secure-brokered-service.md).

When you increment the version on your <xref:Microsoft.ServiceHub.Framework.ServiceMoniker>, you must register each version of your brokered service that you intend to respond to client requests for.
By supporting more than the most recent version of your brokered service, you help maintain backward compatibility for clients of your older brokered service version, which may be especially useful when considering the Live Share scenario where each version of Visual Studio that is sharing the session may be a different version.

Registering your service with a `null` version will serve as a 'catch all' which will match on any client request for which a precise version with a registered service does not exist.
For example you may register your 1.0 and 2.0 service with specific versions, and also register your service with a `null` version.

## <a name="MEF"></a> Use MEF to proffer and register your service

**This requires Visual Studio 2022 Update 2 or later.**

A brokered service may be exported via MEF instead of using a Visual Studio Package as described in the previous two sections.
This has tradeoffs to consider:

Tradeoff | Package proffer | MEF export
--|--|--
Availability | ✅ Brokered service is available immediately on VS startup. | ⚠️ Brokered service may be delayed in availability till MEF has been initialized in the process. This is usually fast, but can take several seconds when the MEF cache is stale.
Cross-platform readiness | ⚠️ Visual Studio for Windows specific code must be authored. | ✅ The brokered service in your assembly may be loaded in Visual Studio for Windows as well as Visual Studio for Mac.

To export your brokered service via MEF instead of using VS packages:

1. Confirm you have no code related to the last two sections. In particular, you should have no code that calls into <xref:Microsoft.VisualStudio.Shell.ServiceBroker.IBrokeredServiceContainer.Proffer%2A?displayProperty=nameWithType> and shouldn't apply the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ProvideBrokeredServiceAttribute> to your package (if any).
1. Implement the `IExportedBrokeredService` interface on your brokered service class.
1. Avoid any main thread dependencies in your constructor or importing property setters. Use the `IExportedBrokeredService.InitializeAsync` method for initializing your brokered service, where main thread dependencies are allowed.
1. Apply the `ExportBrokeredServiceAttribute` to your brokered service class, specifying the information about your service moniker, audience, and any other registration-related information required.
1. If your class requires disposal, implement <xref:System.IDisposable> rather than <xref:System.IAsyncDisposable> since MEF owns the lifetime of your service and only supports synchronous disposal.
1. Ensure your `source.extension.vsixmanifest` file lists the project containing your brokered service as a MEF assembly.

As a MEF part, your brokered service *may* import any other MEF part in the default scope.
When doing so, be sure to use <xref:System.ComponentModel.Composition.ImportAttribute?displayProperty=fullName> rather than <xref:System.Composition.ImportAttribute?displayProperty=fullName>.
This is because the `ExportBrokeredServiceAttribute` derives from <xref:System.ComponentModel.Composition.ExportAttribute?displayProperty=fullName> and using the same MEF namespace throughout a type is required.

A brokered service is unique in being able to import a few special exports:

- <xref:Microsoft.ServiceHub.Framework.IServiceBroker>, which should be used to acquire other brokered services.
- <xref:Microsoft.ServiceHub.Framework.ServiceMoniker>, which can be useful when you export multiple versions of your brokered service and need to detect which version the client requested.
- <xref:Microsoft.ServiceHub.Framework.ServiceActivationOptions>, which can be useful when you require your clients to provide special parameters or a client callback target.
- <xref:Microsoft.ServiceHub.Framework.Services.AuthorizationServiceClient>, which can be useful when you need to perform security checks as described in [How to secure a brokered service](how-to-secure-brokered-service.md).
This object does *not* need to be disposed of by your class, as it will be disposed of automatically when your brokered service is disposed of.

Your brokered service *must not* use MEF's <xref:System.ComponentModel.Composition.ImportAttribute> to acquire other brokered services.
Instead, it can `[Import]` <xref:Microsoft.ServiceHub.Framework.IServiceBroker> and query for brokered services in the traditional way.
Learn more in [How to consume a brokered service](how-to-consume-brokered-service.md).

Here is a sample:

```cs
using System;
using System.ComponentModel.Composition;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceHub.Framework;
using Microsoft.ServiceHub.Framework.Services;
using Microsoft.VisualStudio.Shell.ServiceBroker;

[ExportBrokeredService("Calc", "1.0")]
internal class MefBrokeredService : IExportedBrokeredService, ICalculator
{
    internal static ServiceRpcDescriptor SharedDescriptor { get; } = new ServiceJsonRpcDescriptor(
        new ServiceMoniker("Calc", new Version("1.0")),
        clientInterface: null,
        ServiceJsonRpcDescriptor.Formatters.MessagePack,
        ServiceJsonRpcDescriptor.MessageDelimiters.BigEndianInt32LengthHeader,
        new MultiplexingStream.Options { ProtocolMajorVersion = 3 });

    // IExportedBrokeredService
    public ServiceRpcDescriptor Descriptor => SharedDescriptor;

    [Import]
    IServiceBroker ServiceBroker { get; set; } = null!;

    [Import]
    ServiceMoniker ServiceMoniker { get; set; } = null!;

    [Import]
    ServiceActivationOptions Options { get; set; }

    // IExportedBrokeredService
    public Task InitializeAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public ValueTask<int> AddAsync(int a, int b, CancellationToken cancellationToken = default)
    {
        return new(a + b);
    }

    public ValueTask<int> SubtractAsync(int a, int b, CancellationToken cancellationToken = default)
    {
        return new(a - b);
    }
}
```

### Exporting multiple versions of your brokered service

The `ExportBrokeredServiceAttribute` can be applied to your brokered service multiple times to offer multiple versions of your brokered service.

Your implementation of the `IExportedBrokeredService.Descriptor` property should return a descriptor with a moniker that matches the one the client requested.

Consider this example, where the calculator service exported 1.0 with UTF8 formatting, then later adds a 1.1 export in order to enjoy the performance wins of using MessagePack formatting.

```cs
[ExportBrokeredService("Calc", "1.0")]
[ExportBrokeredService("Calc", "1.1")]
internal class MefBrokeredService : IExportedBrokeredService, ICalculator
{
    internal static ServiceRpcDescriptor SharedDescriptor1_0 { get; } = new ServiceJsonRpcDescriptor(
        new ServiceMoniker("Calc", new Version("1.0")),
        clientInterface: null,
        ServiceJsonRpcDescriptor.Formatters.UTF8,
        ServiceJsonRpcDescriptor.MessageDelimiters.HttpLikeHeaders,
        new MultiplexingStream.Options { ProtocolMajorVersion = 3 });

    internal static ServiceRpcDescriptor SharedDescriptor1_1 { get; } = new ServiceJsonRpcDescriptor(
        new ServiceMoniker("Calc", new Version("1.1")),
        clientInterface: null,
        ServiceJsonRpcDescriptor.Formatters.MessagePack,
        ServiceJsonRpcDescriptor.MessageDelimiters.BigEndianInt32LengthHeader,
        new MultiplexingStream.Options { ProtocolMajorVersion = 3 });

    // IExportedBrokeredService
    public ServiceRpcDescriptor Descriptor =>
        this.ServiceMoniker.Version == SharedDescriptor1_0.Moniker.Version ? SharedDescriptor1_0 :
        this.ServiceMoniker.Version == SharedDescriptor1_1.Moniker.Version ? SharedDescriptor1_1 :
        throw new NotSupportedException();

    [Import]
    ServiceMoniker ServiceMoniker { get; set; } = null!;
}
```

Beginning with Visual Studio 2022 Update 12 (17.12), a `null` versioned service can be exported to match any client request for the service regardless of version including a request with a `null` version.
Such a service can return `null` from the `Descriptor` property in order to reject a client request when it doesn't offer an implementation of the version the client requested.

### Rejecting a service request

A brokered service can reject a client's activation request by throwing from the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.IExportedBrokeredService.InitializeAsync%2A> method.
Throwing causes a <xref:Microsoft.ServiceHub.Framework.ServiceActivationFailedException> to be thrown back to the client.

## Related content
- [Best Practices for Designing a Brokered Service](best-practices-design-brokered-service.md)
- [How to Secure a Brokered Service](how-to-secure-brokered-service.md)
- [Brokered Service Essentials](internals/brokered-service-essentials.md)
- [How to Get a Brokered Service](how-to-consume-brokered-service.md)
- [Use and Provide Brokered Services](use-and-provide-brokered-services.md)
