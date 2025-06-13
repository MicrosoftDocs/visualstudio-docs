---
title: Launching a Program
description: Learn about the series of events that take place when you debug a program using F5 to run the debugger from the IDE.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debug engines, launching
- programs, launching
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Launch a program

Users who want to debug a program can press **F5** to run the debugger from the IDE. This begins a series of events that ultimately result in the IDE's connecting to a debug engine (DE), which is in turn connected, or attached, to the program as follows:

1. The IDE first calls the project package to get the solution's active project debug settings. The settings include the starting directory, the environment variables, the port in which the program will run, and the DE to use to create the program, if specified. These settings are passed to the debug package.

2. If a DE is specified, the DE calls the operating system to launch the program. As a consequence of launching the program, the program's run-time environment loads. For example, if a program is written in MSIL, the common language runtime will be invoked to run the program.

    -or-

    If a DE is not specified, the port calls the operating system to launch the program, which causes the program's run-time environment to load.

   > [!NOTE]
   > If a DE is used to launch a program, it is likely that the same DE will be attached to the program.

3. Depending on whether the DE or the port launched the program, the DE or the run-time environment then creates a program description, or node, and notifies the port that the program is running.

   > [!NOTE]
   > It is recommended that the run-time environment create the program node, because the program node is a lightweight representation of a program that can be debugged. There is no need to load up an entire DE just to create and register a program node. If the DE is designed to run in the process of the IDE, but no IDE is actually running, there needs to be a component that can add a program node to the port.

   The newly created program, along with any other programs, related or unrelated, launched or attached to from the same IDE, compose a debug session.

   Programmatically, when the user first presses **F5**, Visual Studio's debug package calls the project package (which is associated with the type of program being launched) through the <xref:Microsoft.VisualStudio.Shell.Interop.IVsDebuggableProjectCfg.DebugLaunch%2A> method, which in turn fills out a <xref:Microsoft.VisualStudio.Shell.Interop.VsDebugTargetInfo2> structure with the solution's active project debug settings. This structure is passed back to the debug package through a call to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsDebugger2.LaunchDebugTargets2%2A> method. The debug package then instantiates the session debug manager (SDM), which launches the program being debugged and any associated debug engines.

   One of the arguments passed to the SDM is the GUID of the DE to be used to launch the program.

   If the DE GUID is not `GUID_NULL`, the SDM co-creates the DE, and then calls its [LaunchSuspended](../../extensibility/debugger/reference/idebugenginelaunch2-launchsuspended.md) method to launch the program. For example, if a program is written in native code, `IDebugEngineLaunch2::LaunchSuspended` will probably call `CreateProcess` and `ResumeThread` (Win32 functions) to run the program.

   As a consequence of launching the program, the program's run-time environment is loaded. Either the DE or the run-time environment then creates an [IDebugProgramNode2](../../extensibility/debugger/reference/idebugprogramnode2.md) interface to describe the program and passes this interface to [AddProgramNode](../../extensibility/debugger/reference/idebugportnotify2-addprogramnode.md) to notify the port that the program is running.

   If `GUID_NULL` is passed, then the port launches the program. Once the program is running, the run-time environment creates an `IDebugProgramNode2` interface to describe the program and passes it to `IDebugPortNotify2::AddProgramNode`. This notifies the port that the program is running. Then the SDM attaches the debug engine to the running program.

## In this section

[Notifying the port](../../extensibility/debugger/notifying-the-port.md) explains what happens after a program is launched and the port is notified.

 [Attaching after a launch](../../extensibility/debugger/attaching-after-a-launch.md) documents when the debug session is ready to attach the DE to the program.

## Related content
- [Debugging tasks](../../extensibility/debugger/debugging-tasks.md) contains links to various debugging tasks, such as launching a program and evaluating expressions.
