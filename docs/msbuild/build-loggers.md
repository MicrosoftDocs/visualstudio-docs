---
title: Build Loggers | Microsoft Docs
description: Use MSBuild loggers to manage and customize the output of your build and display messages, errors, or warnings in response to specific build events.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- MSBuild, writing loggers
- MSBuild, logging
- logging [MSBuild]
ms.assetid: fa34810d-185a-4d22-92bd-9852915e5f1d
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# Build loggers

Loggers provide a way for you to customize the output of your build and display messages, errors, or warnings in response to specific build events. Each logger is implemented as a .NET class that implements the <xref:Microsoft.Build.Framework.ILogger> interface, which is defined in the *Microsoft.Build.Framework.dll* assembly.

There are two approaches you can use when implementing a logger:

- Implement the <xref:Microsoft.Build.Framework.ILogger> interface directly.
- Derive your class from the helper class, <xref:Microsoft.Build.Utilities.Logger>, which is defined in the *Microsoft.Build.Utilities.dll* assembly. <xref:Microsoft.Build.Utilities.Logger> implements <xref:Microsoft.Build.Framework.ILogger> and provides default implementations of some <xref:Microsoft.Build.Framework.ILogger> members.

  This topic will explain how to write a simple logger that derives from <xref:Microsoft.Build.Utilities.Logger>, and displays messages on the console in response to certain build events.

## Register for events

The purpose of a logger is to gather information on build progress as it is reported by the build engine, and then report that information in a useful way. All loggers must override the <xref:Microsoft.Build.Utilities.Logger.Initialize%2A> method, which is where the logger registers for events. In this example, the logger registers for the <xref:Microsoft.Build.Framework.IEventSource.TargetStarted>, <xref:Microsoft.Build.Framework.IEventSource.ProjectStarted>, and <xref:Microsoft.Build.Framework.IEventSource.ProjectFinished> events.

:::code language="csharp" source="../snippets/csharp/VS_Snippets_Misc/msbuild_SimpleConsoleLogger/CS/msbuild_SimpleConsoleLogger.cs" id="Snippet2":::

## Respond to events

Now that the logger is registered for specific events, it needs to handle those events when they occur. For the <xref:Microsoft.Build.Framework.IEventSource.ProjectStarted>, and <xref:Microsoft.Build.Framework.IEventSource.ProjectFinished> events, the logger simply writes a short phrase and the name of the project file involved in the event. All messages from the logger are written to the console window.

:::code language="csharp" source="../snippets/csharp/VS_Snippets_Misc/msbuild_SimpleConsoleLogger/CS/msbuild_SimpleConsoleLogger.cs" id="Snippet3":::

## Respond to logger verbosity values

In some cases, you may want to only log information from an event if the MSBuild.exe **-verbosity** switch contains a certain value. In this example, the <xref:Microsoft.Build.Framework.IEventSource.TargetStarted> event handler only logs a message if the <xref:Microsoft.Build.Utilities.Logger.Verbosity%2A> property, which is set by the **-verbosity** switch, is equal to <xref:Microsoft.Build.Framework.LoggerVerbosity>`Detailed`.

:::code language="csharp" source="../snippets/csharp/VS_Snippets_Misc/msbuild_SimpleConsoleLogger/CS/msbuild_SimpleConsoleLogger.cs" id="Snippet4":::

## Specify a logger

Once the logger is compiled into an assembly, you need to tell MSBuild to use that logger during builds. This is done using the **-logger** switch with *MSBuild.exe*. For more information on the switches available for *MSBuild.exe*, see [Command-line reference](../msbuild/msbuild-command-line-reference.md).

The following command line builds the project *MyProject.csproj* and uses the logger class implemented in *SimpleLogger.dll*. The **-nologo** switch hides the banner and copyright message and the **-noconsolelogger** switch disables the default MSBuild console logger.

```cmd
MSBuild -nologo -noconsolelogger -logger:SimpleLogger.dll
```

The following command line builds the project with the same logger, but with a `Verbosity` level of `Detailed`.

```cmd
MSBuild -nologo -noconsolelogger -logger:SimpleLogger.dll -verbosity:Detailed
```

## Example 1

### Description

The following example contains the complete code for the logger.

### Code

:::code language="csharp" source="../snippets/csharp/VS_Snippets_Misc/msbuild_SimpleConsoleLogger/CS/msbuild_SimpleConsoleLogger.cs" id="Snippet1":::

## Example 2

### Description

The following example shows how to implement a logger that writes the log to a file rather than displaying it in the console window.

### Code

:::code language="csharp" source="../snippets/csharp/VS_Snippets_Misc/msbuild_BasicLogger/CS/msbuild_BasicLogger.cs" id="Snippet1":::

## See also

- [Obtain build logs](../msbuild/obtaining-build-logs-with-msbuild.md)
- [MSBuild concepts](../msbuild/msbuild-concepts.md)
