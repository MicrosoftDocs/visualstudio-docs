---
description: "This interface enumerates the bound breakpoints associated with a pending breakpoint or breakpoint bound event."
title: IEnumDebugBoundBreakpoints2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugBoundBreakpoints2
helpviewer_keywords:
- IEnumDebugBoundBreakpoints2
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IEnumDebugBoundBreakpoints2

This interface enumerates the bound breakpoints associated with a pending breakpoint or breakpoint bound event.

## Syntax

```
IEnumDebugBoundBreakpoints2 : IUnknown
```

## Notes for Implementers
 The debug engine (DE) implements this interface as part of its support for breakpoints. This interface must be implemented if breakpoints are supported.

## Notes for Callers
 Visual Studio calls:

- [EnumBreakpoints](../../../extensibility/debugger/reference/idebugbreakpointevent2-enumbreakpoints.md) to obtain this interface representing a list of all breakpoints that were triggered.

- [EnumBoundBreakpoints](../../../extensibility/debugger/reference/idebugbreakpointboundevent2-enumboundbreakpoints.md) to obtain this interface representing a list of all breakpoints that were bound.

- [EnumBoundBreakpoints](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-enumboundbreakpoints.md) to obtain this interface representing a list of all breakpoints bound to that pending breakpoint.

## Methods in Vtable Order
 The following table shows the methods of `IEnumDebugBoundBreakpoints2`.

|Method|Description|
|------------|-----------------|
|[Next](../../../extensibility/debugger/reference/ienumdebugboundbreakpoints2-next.md)|Retrieves a specified number of bound breakpoints in an enumeration sequence.|
|[Skip](../../../extensibility/debugger/reference/ienumdebugboundbreakpoints2-skip.md)|Skips a specified number of bound breakpoints in an enumeration sequence.|
|[Reset](../../../extensibility/debugger/reference/ienumdebugboundbreakpoints2-reset.md)|Resets an enumeration sequence to the beginning.|
|[Clone](../../../extensibility/debugger/reference/ienumdebugboundbreakpoints2-clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|
|[GetCount](../../../extensibility/debugger/reference/ienumdebugboundbreakpoints2-getcount.md)|Gets the number of bound breakpoints in an enumerator.|

## Remarks
 Visual Studio uses the bound breakpoints represented by this interface to update the display of breakpoints in the IDE.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [EnumBoundBreakpoints](../../../extensibility/debugger/reference/idebugbreakpointboundevent2-enumboundbreakpoints.md)
- [EnumBoundBreakpoints](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-enumboundbreakpoints.md)
- [EnumBoundBreakpoints](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-enumboundbreakpoints.md)
