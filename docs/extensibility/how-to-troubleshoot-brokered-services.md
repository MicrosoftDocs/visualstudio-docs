---
title: 'How to: Troubleshoot brokered services'
description: Learn how to troubleshoot several common problems that can occur when you try to get a brokered service in the Visual Studio SDK.
monikerRange: '>= vs-2019'
ms.date: 02/18/2022
ms.topic: troubleshooting
helpviewer_keywords:
- brokered services, troubleshooting
ms.assetid: 1972fbf6-246a-41a7-b557-365939c95781
author: aarnott
ms.author: andarno
manager: ansonh
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# How to: Troubleshoot brokered services

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Brokered services may fail in various ways.
Several common ways are described below with suggestions to guide your investigation and possible fixes.

A useful technique to start your investigation with is to check the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] [Activity Log](how-to-use-the-activity-log.md), which often logs errors or warnings when things go awry with brokered services.

## Requesting a service

Perhaps the most common challenge with brokered services is understanding the result or exception they get from a call to <xref:Microsoft.ServiceHub.Framework.IServiceBroker.GetProxyAsync%2A?displayProperty=nameWithType> or <xref:Microsoft.ServiceHub.Framework.IServiceBroker.GetPipeAsync%2A?displayProperty=nameWithType>.
An <xref:Microsoft.ServiceHub.Framework.IServiceBroker> intentionally abstracts away concerns about where and how a brokered service may be activated. But when things go wrong it becomes necessary to drill deeper to diagnose and correct the problem.

### No service

The result of a service request may be `null` when any of the following conditions are true:

- The requested service isn't registered. The brokered service author should register it with <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ProvideBrokeredServiceAttribute> or a hand-authored pkgdef file.
- The requested service is registered with configuration that doesn't expose the service to this client.
  The default scope is <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ServiceAudience.Process?displayProperty=nameWithType>, which means the brokered service can only be activated when it's proffered from the same process as the client.
  If the client is in another process and the intent is for the brokered service to be available to it, change the service registration to expand its <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ServiceAudience>.
- The requested service is registered with <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ServiceAudience.LiveShareGuest?displayProperty=nameWithType>, a Live Share connection exists, but the host doesn't offer that brokered service or the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ProvideBrokeredServiceAttribute.AllowTransitiveGuestClients?displayProperty=nameWithType> property isn't set to `true`.
  When exposing a brokered service over Live Share, please review [How to secure a brokered service](how-to-secure-brokered-service.md).
- The requested service is registered but is missing information about which package to initialize so that its factory can be proffered. The <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ProvideBrokeredServiceAttribute> attribute automatically generates registration that indicates the package the attribute was applied to so that [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] can load that package as needed.
  If the attribute is applied to the wrong package or the pkgdef file is hand-authored, this information may be missing or inaccurate.
- The [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] package responsible for proffering the brokered service throws during initialization or otherwise fails to actually proffer that service factory.
  Check the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] [Activity Log](how-to-use-the-activity-log.md) for evidence of a package load failure.
- The service factory itself returns `null`.

### Service request throws exception

A service request may throw a <xref:Microsoft.ServiceHub.Framework.ServiceCompositionException> when the service factory throws an exception.
This means all the problems listed above that would lead to a `null` result don't apply.
Look at the exception details (including inner exceptions) to understand what went wrong and make any necessary corrections to the client or the service factory.

### Local service where a remote one was expected

A request may be fulfilled locally or remotely, depending on the service registration and the current state of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].
The default scope is <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ServiceAudience.Process?displayProperty=nameWithType> which means the brokered service can only be activated when it's proffered from the same process as the client.

When a brokered service should be exposed from a Live Share host to a connected guest but the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ServiceAudience> is limited to local scopes, a request from a Live Share guest will activate the brokered service from that same machine rather than the host.
Update registration to include <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ServiceAudience.LiveShareGuest?displayProperty=nameWithType> to expose your brokered services over Live Share.
You may also need to set <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ProvideBrokeredServiceAttribute.AllowTransitiveGuestClients?displayProperty=nameWithType> to `true` as well.

> [!IMPORTANT]
> Registration for the brokered service must exist on both the Live Share guest and the host to support the guest in activating the brokered service from the host.
>
> When exposing a brokered service over Live Share, please review [How to secure a brokered service](how-to-secure-brokered-service.md).

## Proffering a service

A brokered service must be proffered from an <xref:Microsoft.VisualStudio.Shell.AsyncPackage> class unless the brokered service is exported via MEF, as described in [How to provide a brokered service](how-to-provide-brokered-service.md).

An attempt to proffer a brokered service will throw an exception if any of these conditions are true:

- The moniker for the service being proffered doesn't exactly match (name and version) a service that has been registered.
- A factory has already been proffered for the same service moniker.

The result of a call to <xref:Microsoft.VisualStudio.Shell.ServiceBroker.IBrokeredServiceContainer.Proffer%2A?displayProperty=nameWithType> is an <xref:System.IDisposable>.
A brokered service becomes unavailable to new requests after this value is disposed.
When your brokered service has specific affinity to some context such as an open solution, it may be appropriate to only proffer the brokered service when that context is active.
It isn't necessary to retain and dispose of this value when your package is disposed.

## Tracing RPC between client and service

Once a connection between client and service is established, tracing their communication can be useful, particularly when they are in different processes.

By default, traces of communications between brokered services that span processes (such that RPC applies) are recorded in .svclog files found in the `%TEMP%\VSLogs` directory.
These xml files are best viewed with the [Service Trace Viewer](/dotnet/framework/wcf/service-trace-viewer-tool-svctraceviewer-exe#using-the-service-trace-viewer-tool).
This tool can open many .svclog files at once and stitch them together to form a multi-party graph to make understanding the RPC between client and service much easier.

A brokered service itself can trace directly to add to these .svclog trace files, further aiding diagnostics of brokered service behavior.
Any traces saved to `%TEMP%\VSLogs` might be collected when the "Report a Problem" command is invoked and the user elects to share logs.

To trace your own messages such that they can be easily discovered and combined with other .svclog traces, your code (whether a brokered service or not) can do something like this:

```cs
// Define your log's ID, a namespace-like fully qualified name.
// In general it is expected that you follow you team's assembly namespace.
// Also an optional parameter, the ServiceMoniker for your service
var myLogId = new LogId("Microsoft.SomeTeam.MyLogName", serviceId: null);

var requestedLevel = new LoggingLevelSettings(SourceLevels.Warning | SourceLevels.ActivityTracing);
var myLogOptions = new LoggerOptions(requestedLevel, PrivacyFlags.MayContainPrivateInformation);

TraceSource myTraceSource;
using (TraceConfiguration traceConfig = await TraceConfiguration.CreateTraceConfigurationInstanceAsync(serviceBroker, ownsServiceBroker: false, cancellationToken))
{
    myTraceSource = await traceConfig.RegisterLogSourceAsync(myLogId, myLogOptions, traceSource: null, cancellationToken);
}
```

The `myTraceSource` can now be used for tracing, as it has the appropriate listeners added to write your traces to a .svclog file.
If you already have a <xref:System.Diagnostics.TraceSource> you wish to use, pass it to the <xref:Microsoft.VisualStudio.LogHub.TraceConfiguration.RegisterLogSourceAsync%2A> method and discard the result as the listeners will be added to your existing <xref:System.Diagnostics.TraceSource>.

When tracing from a brokered service that serves a remote client, an activity is automatically assigned to the <xref:System.Threading.ExecutionContext> that your code runs within that allows the svclog to be stitched together with the client's svclog in order to see a holistic view using the [Service Trace Viewer](/dotnet/framework/wcf/service-trace-viewer-tool-svctraceviewer-exe#using-the-service-trace-viewer-tool).

## See also
- [Using and Providing Brokered Services](use-and-provide-brokered-services.md)
- [How to: Get a Brokered Service](how-to-consume-brokered-service.md)
- [How to: Provide a Brokered Service](how-to-provide-brokered-service.md)
- [Discovering Available Brokered Services](internals/discover-available-brokered-services.md)
