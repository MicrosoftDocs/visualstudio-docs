---
title: "Creating Forwarding Loggers"
description: Create MSBuild forwarding loggers to improve logging efficiency by letting you choose the events you want to monitor when you build projects.
ms.date: "11/04/2016"
ms.topic: concept-article
helpviewer_keywords:
  - "MSBuild, forwarding loggers"
  - "MSBuild, logging"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Create forwarding loggers

Forwarding loggers improve logging efficiency by letting you choose the events you want to monitor when you build projects on a multi-processor system. By enabling forwarding loggers, you can prevent unwanted events from overwhelming the central logger, slowing build time, and cluttering your log.

 To create a forwarding logger, you can either implement the <xref:Microsoft.Build.Framework.IForwardingLogger> interface and then implement its methods manually, or use the <xref:Microsoft.Build.BuildEngine.ConfigurableForwardingLogger> class and its pre-configured methods. (The latter will suffice for most applications.)

## Register events and respond to them

 A forwarding logger gathers information about build events as they are reported by the secondary build engine, which is a worker process that is created by the main build process during a build on a multi-processor system. Then the forwarding logger selects events to forward to the central logger, based on the instructions you have given it.

 You must register forwarding loggers to handle the events you want to monitor. To register for events, loggers must override the <xref:Microsoft.Build.Utilities.Logger.Initialize%2A> method. This method now includes an optional parameter, `nodecount`, that can be set to the number of processors in the system. (By default, the value is 1.)

 Examples of events you can monitor are <xref:Microsoft.Build.Framework.IEventSource.TargetStarted>, <xref:Microsoft.Build.Framework.IEventSource.ProjectStarted>, and <xref:Microsoft.Build.Framework.IEventSource.ProjectFinished>.

 In a multi-processor environment, event messages are likely to be received out of order. Therefore, you must evaluate the events by using the event handler in the forwarding logger and program it to determine which events to pass to the redirector for forwarding to the central logger. To accomplish this, you can use the <xref:Microsoft.Build.Framework.BuildEventContext> class, which is attached to every message, to help identify events you want to forward, and then pass the names of the events to the <xref:Microsoft.Build.BuildEngine.ConfigurableForwardingLogger> class (or a subclass of it). When you use this method, no other specific coding is required to forward events.

## Specify a forwarding logger

 After the forwarding logger has been compiled into an assembly, you must tell MSBuild to use it during builds. To do this, use the `-FileLogger`, `-FileLoggerParameters`, and `-DistributedFileLogger` switches together with *MSBuild.exe*. The `-FileLogger` switch tells *MSBuild.exe* that the logger is directly attached. The `-DistributedFileLogger` switch means that there is a log file per node. To set parameters on the forwarding logger, use the `-FileLoggerParameters` switch. For more information about these and other *MSBuild.exe* switches, see [Command-line reference](../msbuild/msbuild-command-line-reference.md).

## Multi-processor-aware loggers

 When you build a project on a multi-processor system, the build messages from each processor are not automatically interleaved in a unified sequence. Instead, you must establish a message grouping priority by using the <xref:Microsoft.Build.Framework.BuildEventContext> class that is attached to every message. For more information about multi-processor building, see [Logging in a multi-processor environment](writing-multi-processor-aware-loggers.md).

## Related content

- [Obtain build logs](../msbuild/obtaining-build-logs-with-msbuild.md)
- [Build loggers](../msbuild/build-loggers.md)
- [Logging in a multi-processor environment](writing-multi-processor-aware-loggers.md)
