---
description: "This interface represents a breakpoint that is ready to bind to a code location."
title: IDebugPendingBreakpoint2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPendingBreakpoint2
helpviewer_keywords:
- IDebugPendingBreakpoint2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugPendingBreakpoint2

This interface represents a breakpoint that is ready to bind to a code location.

## Syntax

```
IDebugPendingBreakpoint2 : IUnknown
```

## Notes for Implementers
 The debug engine (DE) implements this interface as part of its support for breakpoints.

## Notes for Callers
 A call to [CreatePendingBreakpoint](../../../extensibility/debugger/reference/idebugengine2-creatependingbreakpoint.md) creates a pending breakpoint from an [IDebugBreakpointRequest2](../../../extensibility/debugger/reference/idebugbreakpointrequest2.md) interface. A call to [Bind](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-bind.md) creates an `IDebugBreakpoint2` interface that represents a bound breakpoint in the program.

## Methods in Vtable Order
 The following table shows the methods of `IDebugPendingBreakpoint2`.

|Method|Description|
|------------|-----------------|
|[CanBind](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-canbind.md)|Determines whether this pending breakpoint can bind to a code location.|
|[Bind](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-bind.md)|Binds this pending breakpoint to one or more code locations.|
|[GetState](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-getstate.md)|Gets the state of this pending breakpoint.|
|[GetBreakpointRequest](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-getbreakpointrequest.md)|Gets the breakpoint request that was used to create this pending breakpoint.|
|[Virtualize](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-virtualize.md)|Toggles the virtualized state of this pending breakpoint.|
|[Enable](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-enable.md)|Toggles the enabled state of this pending breakpoint.|
|[SetCondition](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-setcondition.md)|Sets or changes the condition associated with this pending breakpoint.|
|[SetPassCount](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-setpasscount.md)|Sets or changes the pass count associated with this pending breakpoint.|
|[EnumBoundBreakpoints](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-enumboundbreakpoints.md)|Enumerates all breakpoints bound from this pending breakpoint.|
|[EnumErrorBreakpoints](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-enumerrorbreakpoints.md)|Enumerates all error breakpoints that resulted from this pending breakpoint.|
|[Delete](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-delete.md)|Deletes this pending breakpoint and all breakpoints bound from it.|

## Remarks
 `IDebugPendingBreakpoint2` can be thought of as a provider of all the necessary information needed to bind a breakpoint to code that can be applied to one or many programs.

 A pending breakpoint can potentially produce more than one bound breakpoint. For example, a breakpoint in a C++-style template could produce a bound breakpoint for each unique instance of that template.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [CreatePendingBreakpoint](../../../extensibility/debugger/reference/idebugengine2-creatependingbreakpoint.md)
- [GetPendingBreakpoint](../../../extensibility/debugger/reference/idebugbreakpointboundevent2-getpendingbreakpoint.md)
- [GetPendingBreakpoint](../../../extensibility/debugger/reference/idebugboundbreakpoint2-getpendingbreakpoint.md)
- [GetPendingBreakpoint](../../../extensibility/debugger/reference/idebugerrorbreakpoint2-getpendingbreakpoint.md)
