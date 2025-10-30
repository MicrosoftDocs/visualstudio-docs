---
title: Best practices for designing a brokered service
description: Best practices for designing, evolving, and implementing a brokered service.
monikerRange: '>= vs-2019'
ms.date: 01/07/2022
ms.topic: best-practice
helpviewer_keywords:
- brokered services, providing
author: aarnott
ms.author: andarno
manager: ansonh
ms.subservice: extensibility-integration
---
# Best practices for designing a brokered service

Follow the general [guidance and restrictions documented for RPC interfaces](https://microsoft.github.io/vs-streamjsonrpc/docs/proxies.html) for StreamJsonRpc.

In addition, the following guidelines apply to brokered services.

## Method signatures

All methods should take a <xref:System.Threading.CancellationToken> parameter as their last parameter.
This parameter should usually *not* be an optional parameter so callers are less likely to accidentally omit the argument.
Even if the implementation of the method is expected to be trivial, providing a <xref:System.Threading.CancellationToken> allows the client to cancel their own request before it's transmitted to the server.
It also allows for the server's implementation to evolve into something more expensive without having to update the method to add cancellation as an option later.

Consider *avoiding* multiple overloads of the same method on your RPC interface.
While overload resolution usually works (and tests should be written to verify that it does), it relies on *trying* to deserialize arguments based on the parameter types of each overload, resulting in first chance exceptions being thrown as a regular part of picking an overload.
As we want to minimize the number of first chance exceptions thrown in success paths, it's preferable to simply have only one method with a given name.

## Parameter and return types

Remember that all arguments and return values exchanged over RPC are *just data*.
They are all serialized and sent over the wire.
Any methods you define on these data types only operate on that local copy of the data and have no way to communicate back to the RPC service that produced it.
The only exceptions to this serialization behavior are the [exotic types](https://microsoft.github.io/vs-streamjsonrpc/exotic_types/index.html) for which StreamJsonRpc has special support.

Consider using [`ValueTask<T>`](xref:System.Threading.Tasks.ValueTask%601) over [`Task<T>`](xref:System.Threading.Tasks.Task%601) as the return type of methods since [`ValueTask<T>`](xref:System.Threading.Tasks.ValueTask%601) incurs fewer allocations.
When using the non-generic variety (for example, <xref:System.Threading.Tasks.Task> and <xref:System.Threading.Tasks.ValueTask>) it's less important, but <xref:System.Threading.Tasks.ValueTask> may still be preferable.
Be aware of usage restrictions on [`ValueTask<T>`](xref:System.Threading.Tasks.ValueTask%601) as documented on that API. This [blog post](https://devblogs.microsoft.com/dotnet/understanding-the-whys-whats-and-whens-of-valuetask/) and [video](/shows/on-net/understanding-how-to-use-task-and-valuetask) can be helpful in deciding which type to use as well.

## Custom data types

Consider defining all data types to be immutable, which allows for safer sharing of the data across a process without copying and helps to reinforce the idea to consumers that they cannot change the data they receive in response to a query without placing another RPC.

Define your data types as `class` rather than `struct` when using <xref:Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor.Formatters.UTF8?displayProperty=nameWithType>, which avoids the cost of (potentially repeated) boxing when using Newtonsoft.Json.
Boxing does *not* occur when using <xref:Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor.Formatters.MessagePack?displayProperty=nameWithType> so structs may be a suitable option if you are committed to that formatter.

Consider implementing <xref:System.IEquatable%601> and overriding <xref:System.Object.GetHashCode> and <xref:System.Object.Equals(System.Object)> methods on your data types, which enables the client to efficiently store, compare, and reuse data received based on whether it equals data received at another time.

Use the <xref:Microsoft.VisualStudio.RpcContracts.JsonConverters.DiscriminatedTypeJsonConverter%601> to support serializing polymorphic types using JSON.

### Collections

Use readonly collections interfaces in RPC method signatures (for example, <xref:System.Collections.Generic.IReadOnlyList%601>) rather than concrete types (for example, <xref:System.Collections.Generic.List%601> or `T[]`), which allows for potentially more efficient deserialization.

Avoid <xref:System.Collections.Generic.IEnumerable%601>.
Its lack of a `Count` property leads to inefficient code and implies possible late generation of data, which does not apply in an RPC scenario.
Use <xref:System.Collections.Generic.IReadOnlyCollection%601> for unordered collections or <xref:System.Collections.Generic.IReadOnlyList%601> for ordered collections instead.

Consider <xref:System.Collections.Generic.IAsyncEnumerable%601>.
Any other collection type or <xref:System.Collections.Generic.IEnumerable%601> will result in the entire collection being sent in one message.
Using <xref:System.Collections.Generic.IAsyncEnumerable%601> allows for a small initial message and provides the receiver the means to get just as many items from the collection as they want, enumerating it asynchronously.
[Learn more about this novel pattern](https://microsoft.github.io/vs-streamjsonrpc/exotic_types/asyncenumerable.html).

## Observer pattern

Consider using [the observer design pattern](/dotnet/standard/events/observer-design-pattern) in your interface.
This is a simple way for the client to subscribe to data without the many pitfalls that apply to the traditional eventing model described in the next section.

The observer pattern may be as simple as this:

```cs
Task<IDisposable> SubscribeAsync(IObserver<YourDataType> observer);
```

The <xref:System.IDisposable> and <xref:System.IObserver%601> types used above are two of the [exotic types](https://microsoft.github.io/vs-streamjsonrpc/exotic_types/index.html) in StreamJsonRpc, so they get specially marshaled behavior rather than being serialized as mere data.

## Events

Events can be problematic over RPC for several reasons and we recommend the observer pattern described above instead.

Keep in mind the service has no visibility into how many event handlers the client has attached when the service and the client are in separate processes.
<xref:StreamJsonRpc.JsonRpc> will always attach exactly one handler that is responsible for propagating the event to the client.
The client may have zero or more handlers attached on the far side.

Most RPC clients will not have event handlers wired up when they're first connected.
Avoid raising the first event until after the client has invoked a "Subscribe\*" method on your interface to indicate interest and readiness to receive events.

If your event indicates a delta in state (for example, a new item added to a collection), consider raising all past events or describing all current data as if it is new in the event argument when a client subscribes to help them 'sync up' with nothing but event handling code.

Consider accepting extra arguments on the "Subscribe\*" method mentioned above if the client might want to express interest in a subset of data or notifications, to reduce network traffic and CPU required to forward these notifications.

Consider not offering a method that returns the current value if you are also exposing an event to receive change notifications, or actively discourage clients from using it in combination with the event.
A client that subscribes to an event for data and calls a method to get the current value stands to race against changes to that value and either missing a change event or not knowing how to reconcile a change event on one thread with the value obtained on another thread.
This concern is general for any interface—not just when it's over RPC.

## Naming conventions

- Use the `Service` suffix on RPC interfaces and a simple `I` prefix.
- Don't use the `Service` suffix for classes in your SDK. Your library or RPC wrapper should use a name that describes exactly what it does, avoiding the term "service".
- Avoid the term "remote" in interface or member names. Remember brokered services ideally apply as much in local scenarios as remote ones.

## Version compatibility concerns

We want any given brokered service that is exposed to other extensions or exposed over Live Share to be forward and backward compatible, meaning that we should assume that a client may be older or newer than the service and that the functionality should roughly equal that of the lesser of the two applicable versions.

First, let's review the breaking change terminology:

- **Binary breaking change**: An API change that would cause other managed code that compiled against a previous version of the assembly to fail to bind at runtime to the new one. Examples include:
  - Changing the signature of an existing public member.
  - Renaming a public member.
  - Removing a public type.
  - Adding an abstract member to a type, or any member to an interface.

  But the following are *not* binary breaking changes:
  - Adding a non-abstract member to a class or struct.
  - Adding a complete (not-abstract) interface implementation to an existing type.

- **Protocol-breaking change**: A change to the serialized form of some data type or RPC method call such that the remote party cannot properly deserialize and process it. Examples include:
  - Adding required parameters to an RPC method.
  - Removing a member from a data type that was previously guaranteed to be non-null.
  - Adding a requirement that a method call must be placed before other pre-existing operations.
  - Adding, removing, or changing an attribute on a field or property that controls the serialized name of the data in that member.
  - (MessagePack): changing the <xref:System.Runtime.Serialization.DataMemberAttribute.Order?displayProperty=nameWithType> property or `KeyAttribute` integer of an existing member.

  But the following are *not* protocol-breaking changes:
  - Adding an optional member to a data type.
  - Adding members to RPC interfaces.
  - Adding optional parameters to existing methods.
  - Changing a parameter type that represents an integer or float to one with greater length or precision (for example, `int` to `long` or `float` to `double`).
  - Renaming a parameter. This technically is breaking to clients that use JSON-RPC named arguments, but clients using the <xref:Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor> use positional arguments by default and would not be impacted by a parameter name change. This has nothing to do with whether client *source code* uses named argument syntax, to which a parameter rename would be a *source breaking* change.

- **Behavioral breaking change**: A change to the implementation of a brokered service that adds or changes behavior such that older clients may malfunction. Examples include:
  - No longer initializing a member of a data type that was previously always initialized.
  - Throwing an exception under a condition that previously could complete successfully.
  - Returning an error with a different error code than was returned previously.

  But the following are *not* behavioral breaking changes:
  - Throwing a new exception type (because all exceptions are wrapped in <xref:StreamJsonRpc.RemoteInvocationException> anyway).

When breaking changes are required, they can be safely made by registering and proffering a new service moniker.
This moniker can share the same name, but with a higher version number.
The original RPC interface *might* be reusable if there is no binary breaking change. Otherwise, define a new interface for the new service version.
Avoid breaking old clients by continuing to register, proffer, and support the older version as well.

We want to avoid all such breaking changes, except for adding members to RPC interfaces.

### <a name="AddingInterfaceMembers"></a> Adding members to RPC interfaces

Do *not* add members to [an RPC client callback interface](how-to-provide-brokered-service.md#ClientRpcTarget), since many clients may implement that interface and adding members would result in the CLR throwing <xref:System.TypeLoadException> when those types are loaded but don't implement the new interface members.
If you must add members to invoke on an RPC client callback target, define a new interface (which may derive from the original) and then follow the standard process for proffering your brokered service with an incremented version number, and offer a descriptor with the updated client interface type specified.

You *may* add members to RPC interfaces that define a brokered service.
This is not a protocol-breaking change, and is only a binary breaking change to those implementing the service, but presumably you would be updating the service to implement the new member as well.
Since [our guidance](how-to-consume-brokered-service.md#TestingBrokeredClients) is that no one should implement the RPC interface except the brokered service itself (and tests should use mocking frameworks), adding a member to an RPC interface should not break anyone.

These new members should have xml doc comments that identify which service version first added that member.
If a newer client calls the method on an older service that doesn't implement the method, that client can catch <xref:StreamJsonRpc.RemoteMethodNotFoundException>. But that client can (and probably should) predict the failure and avoid the call in the first place.
Best practices for adding members to existing services include:

- If this is the first change within a release of your service: Bump the minor version on your service moniker when you add the member and declare the new descriptor.
- Update your service to register and proffer the new version *in addition to* the old version.
- If you have a client of your brokered service, update your client to request the newer version, and fallback to requesting the older version if the newer one comes back as null.

## Related content
- [How to provide a brokered service](how-to-provide-brokered-service.md)
