---
description: "This interface represents a breakpoint that is bound to a code location."
title: IDebugBoundBreakpoint2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBoundBreakpoint2
helpviewer_keywords:
- IDebugBoundBreakpoint2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugBoundBreakpoint2

This interface represents a breakpoint that is bound to a code location.

## Syntax

```
IDebugBoundBreakpoint2 : IUnknown
```

## Notes for Implementers
 The debug engine (DE) implements this interface as part of its support for breakpoints.

## Notes for Callers
 A call to [Bind](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-bind.md) creates this interface. Calls to [GetBreakpoint](../../../extensibility/debugger/reference/idebugbreakpointunboundevent2-getbreakpoint.md) and [Next](../../../extensibility/debugger/reference/ienumdebugboundbreakpoints2-next.md) can also obtain This interface.

## Methods in Vtable Order
 The following table shows the methods of `IDebugBoundBreakpoint2`.

|Method|Description|
|------------|-----------------|
|[GetPendingBreakpoint](../../../extensibility/debugger/reference/idebugboundbreakpoint2-getpendingbreakpoint.md)|Gets the pending breakpoint from which the specified bound breakpoint was created.|
|[GetState](../../../extensibility/debugger/reference/idebugboundbreakpoint2-getstate.md)|Gets the state of this bound breakpoint.|
|[GetHitCount](../../../extensibility/debugger/reference/idebugboundbreakpoint2-gethitcount.md)|Gets the current hit count for this bound breakpoint.|
|[GetBreakpointResolution](../../../extensibility/debugger/reference/idebugboundbreakpoint2-getbreakpointresolution.md)|Gets the breakpoint resolution that describes this breakpoint.|
|[Enable](../../../extensibility/debugger/reference/idebugboundbreakpoint2-enable.md)|Enables or disables the breakpoint.|
|[SetHitCount](../../../extensibility/debugger/reference/idebugboundbreakpoint2-sethitcount.md)|Sets the hit count for this bound breakpoint.|
|[SetCondition](../../../extensibility/debugger/reference/idebugboundbreakpoint2-setcondition.md)|Sets or changes the condition associated with this bound breakpoint.|
|[SetPassCount](../../../extensibility/debugger/reference/idebugboundbreakpoint2-setpasscount.md)|Sets or change the pass count associated with this bound breakpoint.|
|[Delete](../../../extensibility/debugger/reference/idebugboundbreakpoint2-delete.md)|Deletes the breakpoint.|

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [GetBreakpoint](../../../extensibility/debugger/reference/idebugbreakpointunboundevent2-getbreakpoint.md)
- [Next](../../../extensibility/debugger/reference/ienumdebugboundbreakpoints2-next.md)
- [Bind](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-bind.md)
