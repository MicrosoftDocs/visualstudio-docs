---
title: "Debugging Managed Code"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: fa3aff01-c271-4aa7-b5b1-def560471c84
caps.latest.revision: 34
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
# Debugging Managed Code
This section covers common debugging problems and techniques for managed applications, or applications written in languages that target the common language runtime, such as Visual Basic, C#, and C++. The techniques described here are high-level techniques. For more information, see [Using the Debugger](../VS_debugger/Debugger-Basics.md).  
  
## In This Section  
 [Diagnostic Messages in the Output Window](../VS_debugger/Diagnostic-Messages-in-the-Output-Window.md)  
 Describes the <xref:System.Diagnostics.Debug?qualifyHint=False> and <xref:System.Diagnostics.Trace?qualifyHint=False> classes, with which you can write run-time messages to the **Output** window. These classes include output methods that enable information output without breaking execution and information output that also breaks execution if a specified condition fails.  
  
 [Assertions in Managed Code](../VS_debugger/Assertions-in-Managed-Code.md)  
 Describes assertions in managed code, which test conditions that you specify as arguments to `Assert` methods. In addition, this topic provides example code, information on using <xref:System.Diagnostics.Debug?qualifyHint=False> and <xref:System.Diagnostics.Trace?qualifyHint=False> class methods, considerations in Debug and Release versions of code, side effects, assert arguments, customizing assert behavior, and configuration files.  
  
 [Stop Statements in Visual Basic](../VS_debugger/Stop-Statements-in-Visual-Basic.md)  
 Describes the `Stop` statement, which provides an alternative to setting a breakpoint. Example code is also provided, along with comparisons between the `Stop` statement and the `End` statement, as well as between `Stop` and the `Assert` statement.  
  
 [Walkthrough: Debugging a Windows Form](../VS_debugger/Walkthrough--Debugging-a-Windows-Form.md)  
 Gives step-by-step instructions for creating a Windows Form and debugging that form. A Windows Form, a standard component of a managed Windows application, is one of the most common managed applications. This walkthrough uses Visual C# and Visual Basic, but the techniques for creating a Windows form with C++ are generally similar.  
  
 [Debugging the OnStart Method](../VS_debugger/How-to--Debug-the-OnStart-Method.md)  
 Provides code examples to allow you to debug the `OnStart` method of a managed Windows service. To debug the `OnStart` method of a Windows service, you must add a few lines of code to simulate the service.  
  
 [Mixed-Mode Debugging](../VS_debugger/Debugging-Mixed-Mode-Applications.md)  
 Discusses debugging mixed-mode applications. This means any application that combines native code with managed code.  
  
 [Error: Debugging isn't possible because a kernel debugger is enabled on the system](../VS_debugger/Error--Debugging-Isn-t-Possible-Because-a-Kernel-Debugger-is-Enabled-on-the-System.md)  
 Describes an error message that occurs if you try to debug managed code on a Windows 7, Windows Vista, Windows XP, Windows 2000, or Windows NT system that has been started in debug mode.  
  
 [JIT Optimization and Debugging](../VS_debugger/JIT-Optimization-and-Debugging.md)  
 Describes the effects of JIT optimization on debugging.  
  
 [Debugging LINQ and DLINQ](../VS_debugger/Debugging-LINQ.md)  
 Discusses techniques for debugging LINQ queries.  
  
 [Walkthrough: Debugging a Parallel Application](../VS_debugger/Walkthrough--Debugging-a-Parallel-Application.md)  
 Describes how to use the **Parallel Tasks** and **Parallel Stacks** tool windows to debug a parallel application.  
  
## Related Sections  
 [IntelliTrace](../VS_debugger/IntelliTrace.md)  
 Find bugs faster and easier by recording your app's execution history with IntelliTrace. Step backward and forward through recorded events and calls to examine your app's state at key points in time. Debug your code without setting lots of breakpoints or restarting your app as frequently. Requires Visual Studio Ultimate.  
  
 [Tracing and Instrumenting Applications](../Topic/Tracing%20and%20Instrumenting%20Applications.md)  
 Describes tracing, a way for you to monitor the execution of your application while it is running, and instrumenting, which involves placing trace statements at strategic locations in your code. This topic also provides links to an introduction to instrumentation and tracing, trace switches, trace listeners, tracing code in an application, adding trace statements to application code, and compiling conditionally with <xref:System.Diagnostics.Debug?qualifyHint=False> and <xref:System.Diagnostics.Trace?qualifyHint=False>.  
  
 [/ASSEMBLYDEBUG](../Topic/-ASSEMBLYDEBUG%20\(Add%20DebuggableAttribute\).md)  
 Describes a linker option that adds <xref:System.Diagnostics.DebuggableAttribute?qualifyHint=False> to code written with C++. This attribute is needed to use debugging features such as attach with C++.  
  
 [Debugging Windows Service Applications](../Topic/How%20to:%20Debug%20Windows%20Service%20Applications.md)  
 Provides considerations for debugging Windows service applications, including setting up, attaching to the process, debugging the code in the service's `OnStart` method and the code in the Main method, setting breakpoints, and using the Services Control Manager to start, stop, pause, and continue your service.  
  
 [Debugging and Profiling](../Topic/Debugging,%20Tracing,%20and%20Profiling.md)  
 Discusses debugging .NET Framework applications and the configuration requirements.  
  
 [Debugging Script and Web Applications](../VS_debugger/Debugging-Web-Applications-and-Script.md)  
 Describes common debugging problems and techniques you may encounter when debugging script and Web applications.  
  
 [What’s New for the Debugger in Visual Studio 2015](../VS_debugger/What’s-New-for-the-Debugger-in-Visual-Studio-2015.md)  
 Description of new debugging features added in this release of Visual Studio.  
  
 [Debugging Home Page](../VS_debugger/Debugging-in-Visual-Studio.md)  
 Provides links to the larger sections of the debugging documentation. Information includes what's new in the debugger, settings and preparation, breakpoints, handling exceptions, edit and continue, debugging managed code, debugging Visual C++ projects, debugging COM and ActiveX, debugging DLLs, debugging SQL, and the user interface references.  
  
## See Also  
 [Walkthrough: Debugging Custom Windows Forms Controls at Design Time](../Topic/Walkthrough:%20Debugging%20Custom%20Windows%20Forms%20Controls%20at%20Design%20Time.md)   
 [Debugger Security](../VS_debugger/Debugger-Security.md)   
 [Debugging in Visual Studio](../VS_debugger/Debugging-in-Visual-Studio.md)