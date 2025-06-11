---
description: "Used by a debug engine (DE) to launch and terminate programs."
title: IDebugEngineLaunch2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngineLaunch2
helpviewer_keywords:
- IDebugEngineLaunch2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugEngineLaunch2

Used by a debug engine (DE) to launch and terminate programs.

## Syntax

```
IDebugEngineLaunch2 : IDebugEngine2
```

## Notes for Implementers
 This interface is implemented by a custom DE if it has special requirements for launching a process that cannot be handled entirely by a custom port. This is typically the case when the DE is part of an interpreter and the process being debugged is a script: the interpreter needs to be launched first, and then the script is loaded and started. A port can launch the interpreter, but the script may require special handling (which is where the DE has a role). This interface is implemented only if there are unique requirements for launching a program that a custom port cannot handle.

## Notes for Callers
 This interface is called by the session debug manager (SDM) if the SDM can get this interface from the [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md) interface (using QueryInterface). If this interface can be obtained, the SDM knows that the DE has special requirements and calls this interface to launch the program instead of having the port launch it.

## Methods in Vtable Order
 The following table shows the methods of `IDebugEngineLaunch2`.

|Method|Description|
|------------|-----------------|
|[LaunchSuspended](../../../extensibility/debugger/reference/idebugenginelaunch2-launchsuspended.md)|Launches a process by means of the DE.|
|[ResumeProcess](../../../extensibility/debugger/reference/idebugenginelaunch2-resumeprocess.md)|Resumes process execution.|
|[CanTerminateProcess](../../../extensibility/debugger/reference/idebugenginelaunch2-canterminateprocess.md)|Determines if a process can be terminated.|
|[TerminateProcess](../../../extensibility/debugger/reference/idebugenginelaunch2-terminateprocess.md)|Terminates a process.|

## Requirements
 Header: Msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
