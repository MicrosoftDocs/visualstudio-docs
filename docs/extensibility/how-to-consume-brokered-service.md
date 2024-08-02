---
title: 'Consume a brokered service'
description: Learn how to acquire and use a brokered service to access different features.
monikerRange: '>= vs-2019'
ms.date: 01/11/2022
ms.topic: how-to
helpviewer_keywords:
- brokered services, consuming
author: aarnott
ms.author: andarno
manager: ansonh
ms.subservice: extensibility-integration
---
# Consume a brokered service

This document describes all the code, patterns, and cautions relevant to the acquisition, general use, and disposal of any brokered service.
To learn to *use* a particular brokered service once acquired, look up the particular documentation for that brokered service.

With all code in this document, activating C#'s [nullable reference types](/dotnet/csharp/nullable-references) feature is highly recommended.

## Retrieving an IServiceBroker

To acquire a brokered service, you must first have an instance of <xref:Microsoft.ServiceHub.Framework.IServiceBroker>.
When your code is running in the context of MEF (Managed Extensibility Framework) or a VSPackage, you typically want the global service broker.

Brokered services themselves should use the <xref:Microsoft.ServiceHub.Framework.IServiceBroker> that they're assigned when their [service factory](xref:Microsoft.VisualStudio.Shell.ServiceBroker.BrokeredServiceFactory) is invoked.

### The global service broker

Visual Studio offers two ways to acquire the global service broker.

Use <xref:Microsoft.VisualStudio.Shell.ServiceProvider.GlobalProvider%2A>.<xref:Microsoft.VisualStudio.Shell.ServiceExtensions.GetServiceAsync%2A> to request the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.SVsBrokeredServiceContainer>:

```cs
IBrokeredServiceContainer container = await AsyncServiceProvider.GlobalProvider.GetServiceAsync<SVsBrokeredServiceContainer, IBrokeredServiceContainer>();
IServiceBroker serviceBroker = container.GetFullAccessServiceBroker();
```

Starting with Visual Studio 2022, code running in a MEF activated extension can import the global service broker:

```cs
[Import(typeof(SVsFullAccessServiceBroker))]
IServiceBroker ServiceBroker { get; set; }
```

Notice the `typeof` argument to the Import attribute, which is required.

Each request for the global <xref:Microsoft.ServiceHub.Framework.IServiceBroker> produces a new instance of an object that serves as a view into the global brokered service container.
This unique instance of the service broker allows your client to receive <xref:Microsoft.ServiceHub.Framework.IServiceBroker.AvailabilityChanged> events unique to that client's use.
We recommend that each client/class in your extension acquire its own service broker using either of the above approaches rather than acquiring one instance and sharing it across your entire extension.
This pattern also encourages secure coding patterns where a brokered service should *not* be using the global service broker.

> [!IMPORTANT]
> Implementations of <xref:Microsoft.ServiceHub.Framework.IServiceBroker> do not typically implement <xref:System.IDisposable>, but these objects can't be collected while <xref:Microsoft.ServiceHub.Framework.IServiceBroker.AvailabilityChanged> handlers exist.
Be sure to balance add/remove of event handlers, especially when the code might discard the service broker during the lifetime of the process.

### Context specific service brokers

Using the appropriate service broker is an important requirement of the security model of brokered services, particularly in the context of Live Share sessions.

Brokered services are activated with their own <xref:Microsoft.ServiceHub.Framework.IServiceBroker> and should use this instance for any of their own brokered service needs, including services proffered with <xref:Microsoft.VisualStudio.Shell.ServiceBroker.IBrokeredServiceContainer.Proffer%2A>.
Such code provides a <xref:Microsoft.VisualStudio.Shell.ServiceBroker.BrokeredServiceFactory> that receives a service broker to be used by the instantiated brokered service.

## Retrieving a brokered service proxy

Retrieval of a brokered service is typically done with the <xref:Microsoft.ServiceHub.Framework.IServiceBroker.GetProxyAsync%2A> method.

The <xref:Microsoft.ServiceHub.Framework.IServiceBroker.GetProxyAsync%2A> method will require a <xref:Microsoft.ServiceHub.Framework.ServiceRpcDescriptor> and the service interface as a generic type argument.
The documentation on the brokered service you are requesting should indicate where to get the descriptor and which interface to use.
For brokered services included with Visual Studio, the interface to use should appear in the IntelliSense documentation on the descriptor.
Learn how to find descriptors for Visual Studio brokered services in [Discovering Available Brokered Services](internals/discover-available-brokered-services.md).

```csharp
IServiceBroker broker; // Acquired as described earlier in this topic
IMyService? myService = await broker.GetProxyAsync<IMyService>(serviceDescriptor, cancellationToken);
using (myService as IDisposable)
{
    Assumes.Present(myService); // Throw if service was not available
    await myService.SayHelloAsync();
}
```

As with all brokered service requests, the preceding code activates a new instance of a brokered service.
After using the service, the preceding code disposes of the proxy as execution exits the `using` block.

> [!IMPORTANT]
> Every proxy retrieved must be disposed of, *even if the service interface doesn't derive from <xref:System.IDisposable>*.
> Disposal is important because the proxy often has I/O resources backing it that prevent it from being garbage collected.
> Disposal terminates the I/O, allowing the proxy to be garbage collected.
> Use a conditional cast to <xref:System.IDisposable> for disposal and be prepared for the cast to fail to avoid an exception for `null` proxies or proxies that do not actually implement <xref:System.IDisposable>.

Be sure to install the latest [Microsoft.ServiceHub.Analyzers](https://www.nuget.org/packages/Microsoft.ServiceHub.Analyzers) NuGet package and keep the ISBxxxx analyzer rules enabled to help prevent such leaks.

Disposal of the proxy results in disposal of the brokered service that was dedicated to that client.

If your code requires a brokered service and can't complete its work when the service isn't available, you might display an error dialog to the user if the code owns the user experience rather than throw an exception.

### Client RPC targets

Some brokered services accept or require a client RPC (Remote Procedure Call) target for "callbacks."
Such an option or requirement should be in the documentation of that particular brokered service.
For Visual Studio brokered services this information should be included in the IntelliSense documentation on the descriptor.

In such case, a client can provide one using <xref:Microsoft.ServiceHub.Framework.ServiceActivationOptions.ClientRpcTarget?displayProperty=nameWithType> like this:

```csharp
IMyService? myService = await broker.GetProxyAsync<IMyService>(
    serviceDescriptor,
    new ServiceActivationOptions
    {
        ClientRpcTarget = new MyCallbackObject(),
    },
    cancellationToken);
```

## Invoking the client proxy

The result of requesting a brokered service is an instance of the service interface implemented by a proxy.
This proxy forwards calls and events each direction, with some important differences in behavior from what one might expect when calling the service directly.

### Observer pattern

If the service contract takes parameters of type <xref:System.IObserver%601>, you can learn more about how to construct such a type at [How to implement an observer](/dotnet/standard/events/how-to-implement-an-observer).

An <xref:System.Threading.Tasks.Dataflow.ActionBlock%601> can be adapted to implement <xref:System.IObserver%601> with the <xref:System.Threading.Tasks.Dataflow.DataflowBlock.AsObserver%2A> extension method.
The [System.Reactive.Observer](/previous-versions/dotnet/reactive-extensions/hh229899(v=vs.103)) class from the Reactive framework is another alternative to implementing the interface yourself.

### Exceptions thrown from the proxy

- Expect <xref:StreamJsonRpc.RemoteInvocationException> to be thrown for any exception thrown from the brokered service. The original exception can be found in the <xref:System.Exception.InnerException%2A>.
This is natural behavior for a remotely hosted service because it is behavior from <xref:StreamJsonRpc.JsonRpc>.
When the service is local, the local proxy wraps all exceptions in the same way so that the client code can have just one exception path that works for local and remote services.
  - Check the <xref:StreamJsonRpc.RemoteInvocationException.ErrorCode%2A> property if the service documentation suggests that specific codes are set based on specific conditions that you can branch on.
  - A broader set of errors is communicated by catching <xref:StreamJsonRpc.RemoteRpcException>, which is the base type for the <xref:StreamJsonRpc.RemoteInvocationException>.
- Expect <xref:StreamJsonRpc.ConnectionLostException> to be thrown from any call when the connection to a remote service drops or the process hosting the service crashes.
This is primarily of concern when the service can be acquired remotely.

## Caching of the proxy

There is some expense in the activation of a brokered service and associated proxy, particularly when the service comes from a remote process.
When frequent use of a brokered service warrants caching of the proxy across many calls into a class, the proxy can be stored in a field on that class.
The containing class should be disposable and dispose of the proxy inside its `Dispose` method.
Consider this example:

```csharp
class MyExtension : IDisposable
{
    readonly IServiceBroker serviceBroker;
    IMyService? serviceProxy;

    internal MyExtension(IServiceBroker serviceBroker)
    {
        this.serviceBroker = serviceBroker;
    }

    async Task SayHiAsync(CancellationToken cancellationToken)
    {
        if (this.serviceProxy is null)
        {
            this.serviceProxy = await this.serviceBroker.GetProxyAsync<IMyService>(serviceDescriptor, cancellationToken);
            Assumes.Present(this.serviceProxy);
        }

        await this.serviceProxy.SayHelloAsync();
    }

    public void Dispose()
    {
        (this.serviceProxy as IDisposable)?.Dispose();
    }
}
```

The preceding code is roughly correct, but it doesn't account for race conditions between `Dispose` and `SayHiAsync`.
The code also doesn't account for <xref:Microsoft.ServiceHub.Framework.IServiceBroker.AvailabilityChanged> events that should lead to disposal of the proxy previously acquired and the reacquisition of the proxy the next time it's required.

The <xref:Microsoft.ServiceHub.Framework.ServiceBrokerClient> class is designed to handle these race and invalidation conditions to help keep your own code simple.
Consider this updated example that caches the proxy using this helper class:

```csharp
class MyExtension : IDisposable
{
    readonly ServiceBrokerClient serviceBrokerClient;

    internal MyExtension(IServiceBroker serviceBroker)
    {
        this.serviceBrokerClient = new ServiceBrokerClient(serviceBroker);
    }

    async Task SayHiAsync(CancellationToken cancellationToken)
    {
        using var rental = await this.serviceBrokerClient.GetProxyAsync<IMyService>(descriptor, cancellationToken);
        Assumes.Present(rental.Proxy); // Throw if service is not available
        IMyService myService = rental.Proxy;
        await myService.SayHelloAsync();
    }

    public void Dispose()
    {
        // Disposing the ServiceBrokerClient will dispose of all proxies
        // when their rentals are released.
        this.serviceBrokerClient.Dispose();
    }
}
```

The preceding code is still responsible to dispose of the <xref:Microsoft.ServiceHub.Framework.ServiceBrokerClient> and each rental of a proxy.
Race conditions between disposal and use of the proxy are handled by the <xref:Microsoft.ServiceHub.Framework.ServiceBrokerClient> object, which will dispose of each cached proxy at the time of its own disposal or when the last rental of that proxy has been released, whichever comes last.

### Important caveats regarding the `ServiceBrokerClient`

- <xref:Microsoft.ServiceHub.Framework.ServiceBrokerClient> indexes the cached proxies based on the <xref:Microsoft.ServiceHub.Framework.ServiceMoniker> only.
If you pass in <xref:Microsoft.ServiceHub.Framework.ServiceActivationOptions> and a cached proxy is already available, the cached proxy will be returned without using the <xref:Microsoft.ServiceHub.Framework.ServiceActivationOptions>, leading to unexpected behavior from the service.
Consider using <xref:Microsoft.ServiceHub.Framework.IServiceBroker> directly in such cases.

- Do not store the <xref:Microsoft.ServiceHub.Framework.ServiceBrokerClient.Rental%601> obtained from <xref:Microsoft.ServiceHub.Framework.ServiceBrokerClient.GetProxyAsync%2A?displayProperty=nameWithType> in a field.
The proxy is already cached beyond the scope of one method by the <xref:Microsoft.ServiceHub.Framework.ServiceBrokerClient>.
If you need greater control over the lifetime of the proxy, particularly around reacquisition due to an <xref:Microsoft.ServiceHub.Framework.IServiceBroker.AvailabilityChanged> event, use <xref:Microsoft.ServiceHub.Framework.IServiceBroker> directly instead and store the service proxy in a field.

- Create and store <xref:Microsoft.ServiceHub.Framework.ServiceBrokerClient> to a field rather than a local variable. If you create and use it as a local variable in a method, it's not adding any value over using <xref:Microsoft.ServiceHub.Framework.IServiceBroker> directly, but now you have to dispose of two objects (the client and the rental) instead of one (the service).

### Choosing between IServiceBroker and ServiceBrokerClient

Both are user-friendly, and the default should probably be <xref:Microsoft.ServiceHub.Framework.IServiceBroker>.

Category| <xref:Microsoft.ServiceHub.Framework.IServiceBroker> | <xref:Microsoft.ServiceHub.Framework.ServiceBrokerClient>
--|--|--
User friendly|Yes|Yes
Requires disposal|No|Yes
Manages lifetime of proxy|No. Owner must dispose of proxy when done using it.|Yes, they're kept alive and reused as long as they're valid.
Applicable for stateless services|Yes|Yes
Applicable for stateful services|Yes|No
Appropriate when event handlers are added to proxy|Yes|No
Event to notify when old proxy is invalidated| <xref:Microsoft.ServiceHub.Framework.IServiceBroker.AvailabilityChanged> | <xref:Microsoft.ServiceHub.Framework.ServiceBrokerClient.Invalidated>

<xref:Microsoft.ServiceHub.Framework.ServiceBrokerClient> provides a convenient means for you to get fast and frequent reuse of a proxy, where you don't care if the underlying service is changed out from under you in between top-level operations.
But if you do care about those things and want to manage the lifetime of your proxies yourself, or you need event handlers (which implies you need to manage lifetime of the proxy), you should use <xref:Microsoft.ServiceHub.Framework.IServiceBroker>.

## Resilience to service disruptions

There are a few kinds of service disruptions that are possible with brokered services:

- A [service is not available](#ServiceActivationFailures).
- A [dropped connection](#DroppedConnections) to a previously acquired brokered service.
- A [change in availability of the service](#ServiceAvailabilityChanges) should a future request for that service be made.

### <a name="ServiceActivationFailures"></a> Brokered service activation failures

When a brokered service request can be satisfied by an available service but the service factory throws an unhandled exception, a <xref:Microsoft.ServiceHub.Framework.ServiceActivationFailedException> is thrown back to the client so they can understand and report the failure to the user.

When a brokered service request can't be matched up with any available service, `null` is returned to the client.
In such a case, <xref:Microsoft.ServiceHub.Framework.IServiceBroker.AvailabilityChanged> will be raised when and if that service becomes available later.

The service request might be declined not because the service isn't there, but because the version offered is lower than the version requested.
Your fallback plan might include retrying the service request with lower versions that your client knows exist and is able to interact with.

If/when latency from all the failed version checks becomes noticeable, the client can request the VisualStudioServices.VS2019_4Services.RemoteBrokeredServiceManifest to get a complete idea of what services and versions are available from a remote source.

### <a name="DroppedConnections"></a> Handling dropped connections

A successfully acquired brokered service proxy might fail due to a dropped connection or a crash in the process that hosts it.
After such a disruption, any call made on that proxy will result in <xref:StreamJsonRpc.ConnectionLostException> being thrown.

A brokered service client can proactively detect and react to such connection drops by handling the <xref:StreamJsonRpc.JsonRpc.Disconnected> event.
To reach this event, a proxy must be cast to <xref:StreamJsonRpc.IJsonRpcClientProxy> to obtain the <xref:StreamJsonRpc.JsonRpc> object.
This cast should be made conditionally so as to gracefully fail when the service is local.

```csharp
if (this.myService is IJsonRpcClientProxy clientProxy)
{
    clientProxy.JsonRpc.Disconnected += JsonRpc_Disconnected;
}

void JsonRpc_Disconnected(object? sender, JsonRpcDisconnectedEventArgs args)
{
    if (args.Reason == DisconnectedReason.RemotePartyTerminated)
    {
        // consider reacquisition of the service.
    }
}
```

### <a name="ServiceAvailabilityChanges"></a> Handling service availability changes

Brokered service clients can receive notifications of when they should requery for a brokered service they previously queried for by handling the <xref:Microsoft.ServiceHub.Framework.IServiceBroker.AvailabilityChanged> event.
Handlers to this event should be added *before* requesting a brokered service to ensure an event raised soon after a service request is made isn't lost due to a race condition.

When a brokered service is requested only for the duration of one async method's execution, handling this event isn't recommended.
The event is most relevant to clients that store their proxy for extended periods such that they would need to compensate for service changes and are in a position to refresh their proxy.

This event can be raised on any thread, possibly concurrently to code that is using a service that the event is describing.

Several state changes can lead to raising of this event, including:

- A solution or folder being opened or closed.
- A Live Share session starting.
- A dynamically registered brokered service that was just discovered.

An impacted brokered service only results in this event being raised to clients that have previously requested that service, whether or not that request was fulfilled.

The event is raised at most once per service after each request for that service.
For example if the client requests service **A** and service **B** experiences an availability change, no event will be raised to that client.
Later, when service **A** experiences an availability change, the client will receive the event.
If the client doesn't re-request service **A**, subsequent availability changes for **A** will not result in any further notifications to that client.
Once the client requests **A** again, it becomes eligible to receive the next notification regarding that service.

The event is raised when a service becomes available, is no longer available, or experiences an implementation change that requires all prior service clients to requery for the service.

The <xref:Microsoft.ServiceHub.Framework.ServiceBrokerClient> handles availability change events regarding cached proxies automatically by disposing of the old proxies when any rentals have been returned and requesting a new instance of the service when and if its owner requests one.
This class can substantially simplify your code when the service is stateless and doesn't require that your code attaches event handlers to the proxy.

## Retrieving a brokered service pipe

Although accessing a brokered service through a proxy is the most common and convenient technique, in advanced scenarios it may be preferable or necessary to request a pipe to that service so the client can control the RPC directly or communicate any other data type directly.

A pipe to the brokered service may be obtained via the <xref:Microsoft.ServiceHub.Framework.IServiceBroker.GetPipeAsync%2A> method.
This method takes a <xref:Microsoft.ServiceHub.Framework.ServiceMoniker> instead of a <xref:Microsoft.ServiceHub.Framework.ServiceRpcDescriptor> because the RPC behaviors provided by a descriptor are not required.
When you have a descriptor, you can obtain the moniker from it via the <xref:Microsoft.ServiceHub.Framework.ServiceRpcDescriptor.Moniker%2A?displayProperty=nameWithType> property.

While pipes are bound to I/O they're not eligible for garbage collection.
Avoid memory leaks by always completing these pipes when they will no longer be used.

In the following snippet, a brokered service is activated and the client has a direct pipe to it.
The client then sends the content of a file to the service and disconnects.

```csharp
async Task SendMovieAsync(string movieFilePath, CancellationToken cancellationToken)
{
    IServiceBroker serviceBroker;
    IDuplexPipe? pipe = await serviceBroker.GetPipeAsync(serviceMoniker, cancellationToken);
    if (pipe is null)
    {
        throw new InvalidOperationException($"The brokered service '{serviceMoniker}' is not available.");
    }

    try
    {
        // Open the file optimized for async I/O
        using FileStream fs = new FileStream(movieFilePath, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize: 4096, useAsync: true);
        await fs.CopyToAsync(pipe.Output.AsStream(), cancellationToken);
    }
    catch (Exception ex)
    {
        // Complete the pipe, passing through the exception so the remote side understands what went wrong.
        await pipe.Input.CompleteAsync(ex);
        await pipe.Output.CompleteAsync(ex);
        throw;
    }
    finally
    {
        // Always complete the pipe after successfully using the service.
        await pipe.Input.CompleteAsync();
        await pipe.Output.CompleteAsync();
    }
}
```

## <a name="TestingBrokeredClients"></a> Testing brokered service clients

Brokered services are a reasonable dependency to mock when testing your extension.
When mocking a brokered service, we recommend using a mocking framework that implements the interface on your behalf and injects code that you require to the specific members your client will invoke.
This allows your tests to continue to compile and run without breaks [when members are added to the brokered service interface](best-practices-design-brokered-service.md#AddingInterfaceMembers).

When using the [Microsoft.VisualStudio.Sdk.TestFramework](https://www.nuget.org/packages/microsoft.visualstudio.sdk.testframework) to test your extension, your test can include standard code to proffer a mock service which your client code can query for and run against.
For example suppose you wanted to mock up the VisualStudioServices.VS2022.FileSystem brokered service in your tests.
You could proffer the mock with this code:

```cs
IBrokeredServiceContainer sbc = await AsyncServiceProvider.GlobalProvider.GetServiceAsync<SVsBrokeredServiceContainer, IBrokeredServiceContainer>();
Mock<IFileSystem> mockFileSystem = new Mock<IFileSystem>();
sbc.Proffer(VisualStudioServices.VS2022.FileSystem, (ServiceMoniker moniker, ServiceActivationOptions options, IServiceBroker serviceBroker, CancellationToken cancellationToken) => new ValueTask<object?>(mockFileSystem.Object));
```

The mocked brokered service container doesn't require a proffered service to be registered first as Visual Studio itself does.

Your code under test can acquire the brokered service as normal, except that under the test it will get your mock instead of the real one it would get while running under Visual Studio:

```cs
IBrokeredServiceContainer sbc = await AsyncServiceProvider.GlobalProvider.GetServiceAsync<SVsBrokeredServiceContainer, IBrokeredServiceContainer>();
IServiceBroker serviceBroker = sbc.GetFullAccessServiceBroker();
IFileSystem? proxy = await serviceBroker.GetProxyAsync<IFileSystem>(VisualStudioServices.VS2022.FileSystem);
using (proxy as IDisposable)
{
    Assumes.Present(proxy);
    await proxy.DeleteAsync(new Uri("file://some/file"), recursive: false, null, this.TimeoutToken);
}
```

## Related content

- [Discovering Available Brokered Services](internals/discover-available-brokered-services.md)
- [Brokered Service Essentials](internals/brokered-service-essentials.md)
- [How to: Troubleshoot Brokered Services](how-to-troubleshoot-brokered-services.md)
