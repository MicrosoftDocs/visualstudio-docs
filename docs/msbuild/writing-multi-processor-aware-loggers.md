---
title: "Writing Multi-Processor-Aware Loggers"
description: Learn how MSBuild provides a multi-processor-aware logger and logging model, and lets you create custom "forwarding loggers."
ms.date: 04/03/2024
ms.topic: how-to
helpviewer_keywords:
  - "msbuild, multi-proc aware loggers"
  - "multi-proc loggers"
  - "loggers, multi-proc"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Write multi-processor-aware loggers

The ability of MSBuild to take advantage of multiple processors can decrease project building time, but it also adds complexity to build event logging. In a single-processor environment, events, messages, warnings, and errors arrive at the logger in a predictable, sequential manner. However, in a multi-processor environment, events from different sources can arrive at the same time or out of sequence.

Generating a binary log (`-binlog` or `-bl` switch) and viewing it with the [structured log viewer](https://msbuildlog.com/) largely solves this issue. With MSBuild version 17.8 or later, you can also try the terminal logger (`-tl` switch) for more user-friendly logging output in real time at the console.

For a more general solution, MSBuild provides a multi-processor-aware logger and a logging model that you can use to create custom "forwarding loggers."

## Multi-processor logging challenges

 When you build one or more projects on a multi-processor or multi-core system, MSBuild build events for all the projects are generated at the same time. An avalanche of event messages may arrive at the logger at the same time or out of sequence. Because an MSBuild 2.0 logger is not designed to handle this situation, it can overwhelm the logger and cause increased build times, incorrect logger output, or even a broken build. To address these issues, the logger can process out-of-sequence events and correlate events and their sources.

 You can improve logging efficiency even more by creating a custom forwarding logger. A custom forwarding logger acts as a filter by letting you choose, before you build, only the events you want to monitor. When you use a custom forwarding logger, unwanted events cannot overwhelm the logger, clutter your logs, or slow build times.

## Multi-processor logging models

 To provide for multi-processor-related build issues, MSBuild supports two logging models, central and distributed.

### Central logging model

 In the central logging model, a single instance of *MSBuild.exe* acts as the "central node," and child instances of the central node ("secondary nodes") attach to the central node to help it perform build tasks.

 ![Central Logger Model](../msbuild/media/centralnode.png "CentralNode")

 Loggers of various types that attach to the central node are known as "central loggers." Only one instance of each logger type can be attached to the central node at the same time.

 When a build occurs, the secondary nodes route their build events to the central node. The central node routes all its events, and also those of the secondary nodes, to one or more of the attached central loggers. The loggers then create log files that are based on the incoming data.

 Although only <xref:Microsoft.Build.Framework.ILogger> is required to be implemented by the central logger, we recommend that you also implement <xref:Microsoft.Build.Framework.INodeLogger> so that the central logger initializes with the number of nodes that are participating in the build. The following overload of the <xref:Microsoft.Build.Framework.ILogger.Initialize%2A> method invokes when the engine initializes the logger.

```csharp
public interface INodeLogger: ILogger
{
    public void Initialize(IEventSource eventSource, int nodeCount);
}
```

 Any pre-existing <xref:Microsoft.Build.Framework.ILogger>-based loggers can act as central loggers and can attach to the build. However, central loggers written without explicit support for multi-processor logging scenarios and out-of-order events may break a build or produce meaningless output.

### Distributed logging model

 In the central logging model, too much incoming message traffic can overwhelm the central node, for example, when many projects build at the same time. This can stress system resources and decrease build performance. To ease this problem, MSBuild supports a distributed logging model.

 ![Distributed Logging Model](../msbuild/media/distnode.png "DistNode")

 The distributed logging model extends the central logging model by letting you create a forwarding logger.

#### Forwarding loggers

 A forwarding logger is a secondary, lightweight logger that has an event filter that attaches to a secondary node and receives incoming build events from that node. It filters the incoming events and forwards only the ones that you specify to the central node. This reduces the message traffic that is sent to the central node and improves overall build performance.

 There are two ways to use distributed logging, as follows:

- Customize the pre-fabricated forwarding logger named <xref:Microsoft.Build.BuildEngine.ConfigurableForwardingLogger>.

- Write your own custom forwarding logger.

You can modify `ConfigurableForwardingLogger` to suit your requirements. To do this, call the logger on the command line by using *MSBuild.exe*, and list the build events that you want the logger to forward to the central node.

As an alternative, you can create a custom forwarding logger. By creating a custom forwarding logger, you can fine-tune the behavior of the logger. However, creating a custom forwarding logger is more complex than just customizing the ConfigurableForwardingLogger. You can create a forwarding logger by implementing the <xref:Microsoft.Build.Framework.IForwardingLogger> interface, which derives from <xref:Microsoft.Build.Framework.ILogger>. The interface is defined as:

```csharp
public interface IForwardingLogger: INodeLogger
{
    public IEventRedirector EventRedirector { get; set; }
    public int NodeId { get; set; }
}
```

To forward an event that your logger cares about, call the <xref:Microsoft.Build.Framework.IEventRedirector.ForwardEvent%2A> method of the <xref:Microsoft.Build.Framework.IEventRedirector> interface in your forwarding logger. Pass the appropriate <xref:Microsoft.Build.Framework.BuildEventArgs>, or a derivative, as the parameter. The events will then be forwarded to the central logger and can be acted on there.

For more information, see [Creating forwarding loggers](../msbuild/creating-forwarding-loggers.md).

## Using the ConfigurableForwardingLogger for simple distributed logging

 To attach either a `ConfigurableForwardingLogger` or a custom forwarding logger, use the `-distributedlogger` switch (`-dl` for short) in an *MSBuild.exe* command-line build. The format for specifying the names of the logger types and classes is the same as that for the `-logger` switch, except that a distributed logger always has two logging classes instead of one, the forwarding logger and the central logger. The following is an example of how to attach a custom forwarding logger named XMLForwardingLogger.

```cmd
msbuild.exe myproj.proj -distributedlogger:XMLCentralLogger,MyLogger,Version=1.0.2,Culture=neutral*XMLForwardingLogger,MyLogger,Version=1.0.2,Culture=neutral
```

> [!NOTE]
> An asterisk (*) must separate the two logger names in the `-dl` switch.

 Using the `ConfigurableForwardingLogger` is like using any other logger (as outlined in [Obtaining build logs](../msbuild/obtaining-build-logs-with-msbuild.md)), except that you attach the ConfigurableForwardingLogger logger instead of the typical MSBuild logger and you specify as parameters the events that you want the ConfigurableForwardingLogger to pass on to the central node.

 For example, if you want to be notified only when a build starts and ends, and when an error occurs, you would pass `BUILDSTARTEDEVENT`, `BUILDFINISHEDEVENT`, and `ERROREVENT` as parameters. Multiple parameters can be passed by separating them with semi-colons. The following is an example of how to use the ConfigurableForwardingLogger to forward only the `BUILDSTARTEDEVENT`, `BUILDFINISHEDEVENT`, and `ERROREVENT` events.

```cmd
msbuild.exe myproj.proj -distributedlogger:XMLCentralLogger,MyLogger,Version=1.0.2,Culture=neutral*ConfigureableForwardingLogger,C:\My.dll;BUILDSTARTEDEVENT; BUILDFINISHEDEVENT;ERROREVENT
```

 The following is a list of the available ConfigurableForwardingLogger parameters.

|ConfigurableForwardingLogger Parameters|
| - |
|BUILDSTARTEDEVENT|
|BUILDFINISHEDEVENT|
|PROJECTSTARTEDEVENT|
|PROJECTFINISHEDEVENT|
|TARGETSTARTEDEVENT|
|TARGETFINISHEDEVENT|
|TASKSTARTEDEVENT|
|TASKFINISHEDEVENT|
|ERROREVENT|
|WARNINGEVENT|
|HIGHMESSAGEEVENT|
|NORMALMESSAGEEVENT|
|LOWMESSAGEEVENT|
|CUSTOMEVENT|
|COMMANDLINE|
|PERFORMANCESUMMARY|
|NOSUMMARY|
|SHOWCOMMANDLINE|

## Related content

- [Creating forwarding loggers](../msbuild/creating-forwarding-loggers.md)
