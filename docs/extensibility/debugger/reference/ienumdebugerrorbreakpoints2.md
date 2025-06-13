---
description: "This interface enumerates the error breakpoints associated with a pending breakpoint."
title: IEnumDebugErrorBreakpoints2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugErrorBreakpoints2
helpviewer_keywords:
- IEnumDebugErrorBreakpoints2
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IEnumDebugErrorBreakpoints2

This interface enumerates the error breakpoints associated with a pending breakpoint.

## Syntax

```
IEnumDebugErrorBreakpoints2 : IUnknown
```

## Notes for Implementers
 The debug engine (DE) implements this interface as part of its support for breakpoints.

## Notes for Callers
 Visual Studio calls [CanBind](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-canbind.md) to obtain this interface representing a list of breakpoints that cannot be bound, or [EnumErrorBreakpoints](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-enumerrorbreakpoints.md) to obtain this interface representing a list of breakpoints that were not bound.

## Methods in Vtable Order
 The following table shows the methods of `IEnumDebugErrorBreakpoints2`.

|Method|Description|
|------------|-----------------|
|[Next](../../../extensibility/debugger/reference/ienumdebugerrorbreakpoints2-next.md)|Retrieves a specified number of error breakpoints in an enumeration sequence.|
|[Skip](../../../extensibility/debugger/reference/ienumdebugerrorbreakpoints2-skip.md)|Skips a specified number of error breakpoints in an enumeration sequence.|
|[Reset](../../../extensibility/debugger/reference/ienumdebugerrorbreakpoints2-reset.md)|Resets an enumeration sequence to the beginning.|
|[Clone](../../../extensibility/debugger/reference/ienumdebugerrorbreakpoints2-clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|
|[GetCount](../../../extensibility/debugger/reference/ienumdebugerrorbreakpoints2-getcount.md)|Gets the number of error breakpoints in an enumerator.|

## Remarks
 This interface holds a list of [IDebugErrorBreakpoint2](../../../extensibility/debugger/reference/idebugerrorbreakpoint2.md) interfaces, each of which describes a breakpoint that could not be bound and why it could not be bound. Visual Studio uses the `IEnumDebugErrorBreakpoint2` interface to update the breakpoints shown in the IDE.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [CanBind](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-canbind.md)
- [EnumErrorBreakpoints](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-enumerrorbreakpoints.md)
- [IDebugErrorBreakpoint2](../../../extensibility/debugger/reference/idebugerrorbreakpoint2.md)
