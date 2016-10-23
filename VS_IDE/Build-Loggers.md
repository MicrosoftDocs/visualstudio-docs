---
title: "Build Loggers"
ms.custom: na
ms.date: 10/07/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: fa34810d-185a-4d22-92bd-9852915e5f1d
caps.latest.revision: 11
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Build Loggers
Loggers provide a way for you to customize the output of your build and display messages, errors, or warnings in response to specific build events. Each logger is implemented as a .NET class that implements the <xref:Microsoft.Build.Framework.ILogger?qualifyHint=False> interface, which is defined in the Microsoft.Build.Framework.dll assembly.  
  
 There are two approaches you can use when implementing a logger:  
  
-   Implement the <xref:Microsoft.Build.Framework.ILogger?qualifyHint=False> interface directly.  
  
-   Derive your class from the helper class, <xref:Microsoft.Build.Utilities.Logger?qualifyHint=False>, which is defined in the Microsoft.Build.Utilities.dll assembly. <xref:Microsoft.Build.Utilities.Logger?qualifyHint=False> implements <xref:Microsoft.Build.Framework.ILogger?qualifyHint=False> and provides default implementations of some <xref:Microsoft.Build.Framework.ILogger?qualifyHint=False> members.  
  
 This topic will explain how to write a simple logger that derives from <xref:Microsoft.Build.Utilities.Logger?qualifyHint=False>, and displays messages on the console in response to certain build events.  
  
## Registering for Events  
 The purpose of a logger is to gather information on build progress as it is reported by the build engine, and then report that information in a useful way. All loggers must override the <xref:Microsoft.Build.Utilities.Logger.Initialize?qualifyHint=False> method, which is where the logger registers for events. In this example, the logger registers for the <xref:Microsoft.Build.Framework.IEventSource.TargetStarted?qualifyHint=False>, <xref:Microsoft.Build.Framework.IEventSource.ProjectStarted?qualifyHint=False>, and <xref:Microsoft.Build.Framework.IEventSource.ProjectFinished?qualifyHint=False> events.  
  
 [!CODE [msbuild_SimpleConsoleLogger#2](../CodeSnippet/VS_Snippets_Misc/msbuild_SimpleConsoleLogger#2)]  
  
## Responding to Events  
 Now that the logger is registered for specific events, it needs to handle those events when they occur. For the <xref:Microsoft.Build.Framework.IEventSource.ProjectStarted?qualifyHint=False>, and <xref:Microsoft.Build.Framework.IEventSource.ProjectFinished?qualifyHint=False> events, the logger simply writes a short phrase and the name of the project file involved in the event. All messages from the logger are written to the console window.  
  
 [!CODE [msbuild_SimpleConsoleLogger#3](../CodeSnippet/VS_Snippets_Misc/msbuild_SimpleConsoleLogger#3)]  
  
## Responding to Logger Verbosity Values  
 In some cases, you may want to only log information from an event if the MSBuild.exe **/verbosity** switch contains a certain value. In this example, the <xref:Microsoft.Build.Framework.IEventSource.TargetStarted?qualifyHint=False> event handler only logs a message if the <xref:Microsoft.Build.Utilities.Logger.Verbosity?qualifyHint=False> property, which is set by the **/verbosity** switch, is equal to <xref:Microsoft.Build.Framework.LoggerVerbosity?qualifyHint=False>`Detailed`.  
  
 [!CODE [msbuild_SimpleConsoleLogger#4](../CodeSnippet/VS_Snippets_Misc/msbuild_SimpleConsoleLogger#4)]  
  
## Specifying a Logger  
 Once the logger is compiled into an assembly, you need to tell MSBuild to use that logger during builds. This is done using the **/logger** switch with MSBuild.exe. For more information on the switches available for MSBuild.exe, see [Command-Line Reference](../VS_IDE/MSBuild-Command-Line-Reference.md).  
  
 The following command line builds the project `MyProject.csproj` and uses the logger class implemented in `SimpleLogger.dll`. The **/nologo** switch hides the banner and copyright message and the **/noconsolelogger** switch disables the default MSBuild console logger.  
  
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
 [!CODE [msbuild_SimpleConsoleLogger#1](../CodeSnippet/VS_Snippets_Misc/msbuild_SimpleConsoleLogger#1)]  
  
### Comments  
  
## Example  
  
### Description  
 The following example shows how to implement a logger that writes the log to a file rather than displaying it in the console window.  
  
### Code  
 [!CODE [msbuild_BasicLogger#1](../CodeSnippet/VS_Snippets_Misc/msbuild_BasicLogger#1)]  
  
### Comments  
  
## See Also  
 [Obtaining Build Logs](../VS_IDE/Obtaining-Build-Logs-with-MSBuild.md)   
 [MSBuild Concepts](../VS_IDE/MSBuild-Concepts.md)