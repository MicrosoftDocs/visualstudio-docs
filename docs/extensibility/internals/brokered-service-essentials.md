---
title: Brokered service essentials
description: Learn about brokered services, which provide RPC-compatible interfaces to VS functionality.
monikerRange: '>= vs-2019'
ms.date: 01/06/2022
ms.topic: conceptual
helpviewer_keywords:
- brokered services, essentials
author: aarnott
ms.author: andarno
manager: ansonh
ms.subservice: extensibility-integration
---
# Brokered service essentials

A brokered service is a service acquired via an <xref:Microsoft.ServiceHub.Framework.IServiceBroker>, and is exposed as an RPC-compatible interface to enable the service and its client to exist in distinct AppDomains, processes or even across machines (in the case of Live Share).
The brokered service may be proffered from the main Visual Studio process or some of its auxiliary processes, and may be consumed by any of these processes by a Visual Studio extension.

More (non-brokered) Visual Studio services are available via the <xref:System.IServiceProvider> interface as described in [Using and Providing Services](../using-and-providing-services.md).
Such services are typically only available in the main Visual Studio process but expose a larger set of functionality than brokered services.

A Visual Studio extension running on a Live Share guest may provide additional functionality by accessing a subset of these services as proffered by the Live Share host.
Authorization checks apply over Live Share connections to mitigate the risk of an ill-behaving Live Share guest compromising the security of the Live Share host.
Authors of brokered services who choose to expose their services over Live Share should take care to implement authorization checks as described in [How to provide a brokered service](../how-to-provide-brokered-service.md).

## Service broker

Visual Studio has one global <xref:Microsoft.ServiceHub.Framework.IServiceBroker>, analogous to (and retrievable from) the <xref:Microsoft.VisualStudio.Shell.ServiceProvider.GlobalProvider%2A> that exposes other service.
It may also be retrieved via MEF.

There may be other more context specific service brokers proffered by specific Visual Studio features that want to aggregate the global one with one of their own that offers additional services (or perhaps suppresses some).

An <xref:Microsoft.ServiceHub.Framework.IServiceBroker> is (intentionally) a black box that allows a client to get services that may be local, in another process, or on another machine.
Service brokers may be aggregates of one or many others, with policies applied.

Based on the context the Visual Studio process is in, this global service broker is an aggregate of a changing set of other service brokers.
Context changes within the process may change the set of brokered services that may be activated.
For example when a solution is loaded a service specifically related to the active solution may become available.
That same service may be available in an Open Folder view as well, albeit with a different backing implementation.
The change in service implementation would be transparent to a client of that service since both implementations must fulfill the same contract, but the client is required to re-query for the service across this context change (of which they would be notified via <xref:Microsoft.ServiceHub.Framework.IServiceBroker.AvailabilityChanged>) to get the new instance.

The service broker is typically used to obtain a proxy to the service.
That is, instead of receiving a reference to the service object directly, the client receives a stub that forwards all method calls to the service and results or exceptions back to the client.
It may also forward events raised by the service to the client.
In some cases a service may support or require that the client offers a "target object" that the service can invoke methods on to call back to the client.

## Brokered service container

Services must be proffered into the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.IBrokeredServiceContainer> in order to be available from the global <xref:Microsoft.ServiceHub.Framework.IServiceBroker>.
This service container is responsible not only for exposing the service factory to the service broker, but also for controlling which clients have access to the service and to notify those clients when access to that service changes.

## Composition of a brokered service

A brokered service consists of the following elements:

- An interface that declares the service's functionality and serves as a contract between the service and its clients.
- An implementation of that interface.
- A <xref:Microsoft.ServiceHub.Framework.ServiceMoniker> to assign a name and a version to the service.
- A <xref:Microsoft.ServiceHub.Framework.ServiceRpcDescriptor> that combines the <xref:Microsoft.ServiceHub.Framework.ServiceMoniker> with behavior for handling RPC when necessary.
- Code to proffer the service factory
- Service registration

### Service interface

This may be a standard .NET interface (often written in C#).
To allow brokered service clients and services to exist in distinct processes and communicate over RPC, this interface must abide by restrictions as specified by the <xref:Microsoft.ServiceHub.Framework.ServiceRpcDescriptor> that your service will use.
These restrictions typically include that properties and indexers are not allowed, and most or all methods return <xref:System.Threading.Tasks.Task> or another async-compatible return type.

### Brokered service monikers and descriptors

Activating a service requires knowing its moniker.
Because the moniker is included in the service's descriptor, a client can typically just deal with the <xref:Microsoft.ServiceHub.Framework.ServiceRpcDescriptor>.
A descriptor adds the behavior necessary to set up an RPC connection between the brokered service and its client or when required to serialize RPC calls to/from a <xref:System.IO.Stream>.

Visual Studio recommends using the <xref:Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor> derived type for brokered services which utilizes the StreamJsonRpc library when the client and service require RPC to communicate.
StreamJsonRpc applies certain restrictions on the service interface as [described here](https://microsoft.github.io/vs-streamjsonrpc/docs/dynamicproxy.html).

A descriptor rarely needs to be used directly.
Instead, it's typically acquired from <xref:Microsoft.VisualStudio.VisualStudioServices> or a library that offers the service, then used as an argument to <xref:Microsoft.ServiceHub.Framework.IServiceBroker.GetProxyAsync%2A>.

Both the <xref:Microsoft.ServiceHub.Framework.ServiceMoniker> and <xref:Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor> classes are immutable and thus safe to share as `static readonly` fields or properties.
Any other <xref:Microsoft.ServiceHub.Framework.ServiceRpcDescriptor>-derived type should be immutable.

A <xref:Microsoft.ServiceHub.Framework.ServiceMoniker> is serializable.
A <xref:Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor> isn't serializable.

### Service audience

Every brokered service is registered with a selection of flags from <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ServiceAudience>.
These flags control which clients and over which connections the brokered service will be exposed to.

A typical selection is <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ServiceAudience.Local?displayProperty=nameWithType>, which exposes the service to any local process within a Visual Studio session.
With this setting, the service is always activated locally, even if a Live Shared session is active.

When the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ServiceAudience.LiveShareGuest?displayProperty=nameWithType> flag is added, a Live Share guest that requests that brokered service will get a proxy to that brokered service over the remote connection with the Live Share host.

Any combination of flags defined on <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ServiceAudience> is legal.
The <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ServiceAudience.LiveShareGuest> flag may be set *without* also setting the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ServiceAudience.Local> flag, for example to expose a brokered service *only* to Live Share guests (from a Live Share host) and never to be available locally (where client and service are in the same process).

The <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ServiceAudience.RemoteExclusiveClient> and <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ServiceAudience.RemoteExclusiveServer> flags are deprecated.

When a client requests a brokered service, it does not need to know what the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ServiceAudience> is for that service or where the service will be activated.
However it can be useful for a service to document this value and for a developer that is consuming the service to be aware of where a service might be activated so they can anticipate the kind of data that may be coming from that service in various contexts, and when a service might be available.

## Composition of a brokered client

When a client requests a brokered service, it either gets `null` back when the service is unavailable, a <xref:Microsoft.ServiceHub.Framework.ServiceActivationFailedException> thrown if the service fails in activation, or it gets a *proxy* to the service.
A proxy is used whether the brokered service is activated in the same process as the client or a different one.
This proxy helps to harmonize usage patterns across the local and remote service cases so that the client need not be aware of where the service is located.

## Related content

- [Discovering Available Brokered Services](discover-available-brokered-services.md)
- [Using and Providing Brokered Services](../use-and-provide-brokered-services.md)
- [How to Provide a Brokered Service](../how-to-provide-brokered-service.md).
- [How to Get a Brokered Service](../how-to-consume-brokered-service.md).
