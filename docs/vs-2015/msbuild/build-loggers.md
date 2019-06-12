---
title: "Build Loggers | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
helpviewer_keywords: 
  - "MSBuild, writing loggers"
  - "MSBuild, logging"
  - "logging [MSBuild]"
ms.assetid: fa34810d-185a-4d22-92bd-9852915e5f1d
caps.latest.revision: 14
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Build Loggers
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Loggers provide a way for you to customize the output of your build and display messages, errors, or warnings in response to specific build events. Each logger is implemented as a .NET class that implements the <xref:Microsoft.Build.Framework.ILogger> interface, which is defined in the Microsoft.Build.Framework.dll assembly.  
  
 There are two approaches you can use when implementing a logger:  
  
- Implement the <xref:Microsoft.Build.Framework.ILogger> interface directly.  
  
- Derive your class from the helper class, <xref:Microsoft.Build.Utilities.Logger>, which is defined in the Microsoft.Build.Utilities.dll assembly. <xref:Microsoft.Build.Utilities.Logger> implements <xref:Microsoft.Build.Framework.ILogger> and provides default implementations of some <xref:Microsoft.Build.Framework.ILogger> members.  
  
  This topic will explain how to write a simple logger that derives from <xref:Microsoft.Build.Utilities.Logger>, and displays messages on the console in response to certain build events.  
  
## Registering for Events  
 The purpose of a logger is to gather information on build progress as it is reported by the build engine, and then report that information in a useful way. All loggers must override the <xref:Microsoft.Build.Utilities.Logger.Initialize%2A> method, which is where the logger registers for events. In this example, the logger registers for the <xref:Microsoft.Build.Framework.IEventSource.TargetStarted>, <xref:Microsoft.Build.Framework.IEventSource.ProjectStarted>, and <xref:Microsoft.Build.Framework.IEventSource.ProjectFinished> events.  
  
 [!code-csharp[msbuild_SimpleConsoleLogger#2](../snippets/csharp/VS_Snippets_Misc/msbuild_SimpleConsoleLogger/CS/msbuild_SimpleConsoleLogger.cs#2)]  
  
## Responding to Events  
 Now that the logger is registered for specific events, it needs to handle those events when they occur. For the <xref:Microsoft.Build.Framework.IEventSource.ProjectStarted>, and <xref:Microsoft.Build.Framework.IEventSource.ProjectFinished> events, the logger simply writes a short phrase and the name of the project file involved in the event. All messages from the logger are written to the console window.  
  
 [!code-csharp[msbuild_SimpleConsoleLogger#3](../snippets/csharp/VS_Snippets_Misc/msbuild_SimpleConsoleLogger/CS/msbuild_SimpleConsoleLogger.cs#3)]  
  
## Responding to Logger Verbosity Values  
 In some cases, you may want to only log information from an event if the MSBuild.exe **/verbosity** switch contains a certain value. In this example, the <xref:Microsoft.Build.Framework.IEventSource.TargetStarted> event handler only logs a message if the <xref:Microsoft.Build.Utilities.Logger.Verbosity%2A> property, which is set by the **/verbosity** switch, is equal to <xref:Microsoft.Build.Framework.LoggerVerbosity>`Detailed`.  
  
 [!code-csharp[msbuild_SimpleConsoleLogger#4](../snippets/csharp/VS_Snippets_Misc/msbuild_SimpleConsoleLogger/CS/msbuild_SimpleConsoleLogger.cs#4)]  
  
## Specifying a Logger  
 Once the logger is compiled into an assembly, you need to tell [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] to use that logger during builds. This is done using the **/logger** switch with MSBuild.exe. For more information on the switches available for MSBuild.exe, see [Command-Line Reference](../msbuild/msbuild-command-line-reference.md).  
  
 The following command line builds the project `MyProject.csproj` and uses the logger class implemented in `SimpleLogger.dll`. The **/nologo** switch hides the banner and copyright message and the **/noconsolelogger** switch disables the default [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] console logger.  
  
```  
MSBuild /nologo /noconsolelogger /logger:SimpleLogger.dll  
```  
  
 The following command line builds the project with the same logger, but with a `Verbosity` level of `Detailed`.  
  
```  
MSBuild /nologo /noconsolelogger /logger:SimpleLogger.dll /verbosity:Detailed  
```  
  
## Example  
  
### Description  
 The following example contains the complete code for the logger.  
  
### Code  
 [!code-csharp[msbuild_SimpleConsoleLogger#1](../snippets/csharp/VS_Snippets_Misc/msbuild_SimpleConsoleLogger/CS/msbuild_SimpleConsoleLogger.cs#1)]  
  
### Comments  
  
## Example  
  
### Description  
 The following example shows how to implement a logger that writes the log to a file rather than displaying it in the console window.  
  
### Code  
 [!code-csharp[msbuild_BasicLogger#1](../snippets/csharp/VS_Snippets_Misc/msbuild_BasicLogger/CS/msbuild_BasicLogger.cs#1)]  
  
### Comments  
  
## See Also  
 [Obtaining Build Logs](../msbuild/obtaining-build-logs-with-msbuild.md)   
 [MSBuild Concepts](../msbuild/msbuild-concepts.md)
