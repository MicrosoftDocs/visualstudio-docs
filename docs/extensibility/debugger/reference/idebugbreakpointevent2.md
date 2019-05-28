---
title: "IDebugBreakpointEvent2 | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugBreakpointEvent2"
helpviewer_keywords:
  - "IDebugBreakpointEvent2 interface"
ms.assetid: 50b3a7a7-331b-42c8-922c-ff3522ebe1da
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# IDebugBreakpointEvent2
The debug engine (DE) sends this interface to the session debug manager (SDM) when a program stops at a breakpoint.

## Syntax

```
IDebugBreakpointEvent2 : IUnknown
```

## Notes for Implementers
 The DE implements this interface as part of its support for breakpoints. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface (the SDM uses [QueryInterface](/cpp/atl/queryinterface) to access the `IDebugEvent2` interface).

## Notes for Callers
 The DE creates and sends this event object when at least one breakpoint is encountered in the program. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function supplied by the SDM when it attached to the program being debugged.

## Methods in Vtable Order
 The following table shows the methods of `IDebugBreakpointEvent2`.

|Method|Description|
|------------|-----------------|
|[EnumBreakpoints](../../../extensibility/debugger/reference/idebugbreakpointevent2-enumbreakpoints.md)|Creates an enumerator for all the breakpoints that fired at the current code location.|

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)