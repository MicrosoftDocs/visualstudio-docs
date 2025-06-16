---
description: "This interface tells the session debug manager (SDM) that a pending breakpoint could not be bound to a loaded program, either because of a warning or an error."
title: IDebugBreakpointErrorEvent2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBreakpointErrorEvent2
helpviewer_keywords:
- IDebugBreakpointErrorEvent2
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugBreakpointErrorEvent2

This interface tells the session debug manager (SDM) that a pending breakpoint could not be bound to a loaded program, either because of a warning or an error.

## Syntax

```
IDebugBreakpointErrorEvent2 : IUnknown
```

## Notes for Implementers
 The DE implements this interface as part of its support for breakpoints. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface (the SDM uses [QueryInterface](/cpp/atl/queryinterface) to access the `IDebugEvent2` interface).

## Notes for Callers
 The DE creates and sends this event object when a pending breakpoint cannot be bound to the program being debugged. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function supplied by the SDM when it attached to the program being debugged.

## Methods in Vtable Order
 The following table shows the methods of `IDebugBreakpointErrorEvent2`.

|Method|Description|
|------------|-----------------|
|[GetErrorBreakpoint](../../../extensibility/debugger/reference/idebugbreakpointerrorevent2-geterrorbreakpoint.md)|Gets the [IDebugErrorBreakpoint2](../../../extensibility/debugger/reference/idebugerrorbreakpoint2.md) interface that describes the warning or error.|

## Remarks
 Whenever a breakpoint is bound, an event is sent to the SDM. If the breakpoint cannot be bound, an `IDebugBreakpointErrorEvent2` is sent; otherwise, an [IDebugBreakpointBoundEvent2](../../../extensibility/debugger/reference/idebugbreakpointboundevent2.md) is sent.

 For example, when the condition associated with the pending breakpoint fails to parse or evaluate, a warning is sent that the pending breakpoint cannot be bound at this time. This may occur if the code for the breakpoint has not loaded yet.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
- [IDebugErrorBreakpoint2](../../../extensibility/debugger/reference/idebugerrorbreakpoint2.md)
- [IDebugPendingBreakpoint2](../../../extensibility/debugger/reference/idebugpendingbreakpoint2.md)
- [IDebugBreakpointBoundEvent2](../../../extensibility/debugger/reference/idebugbreakpointboundevent2.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
