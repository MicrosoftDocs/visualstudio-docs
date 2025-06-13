---
description: "This interface is sent by the debug engine (DE) to the session debug manager (SDM) when a program has run to completion."
title: IDebugProgramDestroyEvent2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramDestroyEvent2
helpviewer_keywords:
- IDebugProgramDestroyEvent2
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugProgramDestroyEvent2

This interface is sent by the debug engine (DE) to the session debug manager (SDM) when a program has run to completion.

## Syntax

```
IDebugProgramDestroyEvent2 : IUnknown
```

## Notes for Implementers
 The DE or the custom port supplier implements this interface to report that a program has been terminated and is no longer available for debugging. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](/cpp/atl/queryinterface) to access the `IDebugEvent2` interface.

## Notes for Callers
 The DE or the custom port supplier creates and sends this event object to report the termination of a program. The DE sends this event by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged. The custom port supplier sends this event using the [IDebugPortEvents2](../../../extensibility/debugger/reference/idebugportevents2.md) interface.

## Methods in Vtable Order
 The following table shows the method of `IDebugProgramDestroyEvent2`.

|Method|Description|
|------------|-----------------|
|[GetExitCode](../../../extensibility/debugger/reference/idebugprogramdestroyevent2-getexitcode.md)|Gets the program's exit code.|

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
