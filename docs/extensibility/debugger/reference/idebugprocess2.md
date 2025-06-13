---
description: "This interface represents a process running on a port."
title: IDebugProcess2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProcess2
helpviewer_keywords:
- IDebugProcess2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugProcess2

This interface represents a process running on a port. If the port is the local port, then `IDebugProcess2` usually represents a physical process on the local machine.

## Syntax

```
IDebugProcess2 : IUnknown
```

## Notes for Implementers
 This interface is implemented by a custom port supplier to manage programs as a group. This interface must be implemented by the port supplier.

 A debug engine also implements this interface if it supports launching a program through [LaunchSuspended](../../../extensibility/debugger/reference/idebugenginelaunch2-launchsuspended.md).

## Notes for Callers
 This interface is called primarily by the session debug manager (SDM) in order to interact with a group of programs identified in this process.

 Call [GetProcess](../../../extensibility/debugger/reference/idebugprogram2-getprocess.md) or [GetProcess](../../../extensibility/debugger/reference/idebugport2-getprocess.md) to get this interface. This interface is also returned by calling `IDebugEngineLaunch2::LaunchSuspended`.

## Methods in Vtable Order
 The following table shows the methods of `IDebugProcess2`.

|Method|Description|
|------------|-----------------|
|[GetInfo](../../../extensibility/debugger/reference/idebugprocess2-getinfo.md)|Gets a description of the process.|
|[EnumPrograms](../../../extensibility/debugger/reference/idebugprocess2-enumprograms.md)|Enumerates the programs that are contained in this process.|
|[GetName](../../../extensibility/debugger/reference/idebugprocess2-getname.md)|Gets the title, friendly name, or file name of the process.|
|[GetServer](../../../extensibility/debugger/reference/idebugprocess2-getserver.md)|Gets the instance of a machine server this process is running on.|
|[Terminate](../../../extensibility/debugger/reference/idebugprocess2-terminate.md)|Terminates the process.|
|[Attach](../../../extensibility/debugger/reference/idebugprocess2-attach.md)|Attaches to the process.|
|[CanDetach](../../../extensibility/debugger/reference/idebugprocess2-candetach.md)|Determines if the SDM can detach the process.|
|[Detach](../../../extensibility/debugger/reference/idebugprocess2-detach.md)|Detaches the debugger from the process.|
|[GetPhysicalProcessId](../../../extensibility/debugger/reference/idebugprocess2-getphysicalprocessid.md)|Gets the system process identifier.|
|[GetProcessId](../../../extensibility/debugger/reference/idebugprocess2-getprocessid.md)|Gets a globally unique identifier for this process.|
|[GetAttachedSessionName](../../../extensibility/debugger/reference/idebugprocess2-getattachedsessionname.md)<br /><br /> [DEPRECATED]|Gets the name of the session that is debugging the process.<br /><br /> [DEPRECATED. SHOULD ALWAYS RETURN `E_NOTIMPL`.]|
|[EnumThreads](../../../extensibility/debugger/reference/idebugprocess2-enumthreads.md)|Enumerates the threads running in the process.|
|[CauseBreak](../../../extensibility/debugger/reference/idebugprocess2-causebreak.md)|Requests that the next program running code in this process stop.|
|[GetPort](../../../extensibility/debugger/reference/idebugprocess2-getport.md)|Gets the port that this process is running on.|

## Remarks
 An `IDebugProcess2` contains one or more [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) interfaces.

## Requirements
 Header: Msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [GetProcess](../../../extensibility/debugger/reference/idebugport2-getprocess.md)
- [LaunchSuspended](../../../extensibility/debugger/reference/idebugenginelaunch2-launchsuspended.md)
- [GetProcess](../../../extensibility/debugger/reference/idebugprogram2-getprocess.md)
- [Next](../../../extensibility/debugger/reference/ienumdebugprocesses2-next.md)
- [Event](../../../extensibility/debugger/reference/idebugportevents2-event.md)
- [IDebugEngineLaunch2](../../../extensibility/debugger/reference/idebugenginelaunch2.md)
- [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md)
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
