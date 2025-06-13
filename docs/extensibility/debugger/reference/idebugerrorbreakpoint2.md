---
description: "This interface represents an error or warning breakpoint, such as an invalid location, an invalid expression, or the reasons why the pending breakpoint has not bound (code not loaded yet, and so on)."
title: IDebugErrorBreakpoint2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugErrorBreakpoint2
helpviewer_keywords:
- IDebugErrorBreakpoint2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugErrorBreakpoint2

This interface represents an error or warning breakpoint, such as an invalid location, an invalid expression, or the reasons why the pending breakpoint has not bound (code not loaded yet, and so on).

## Syntax

```
IDebugErrorBreakpoint2 : IUnknown
```

## Notes for Implementers
 A debug engine implements this interface as part of its support for breakpoints. This interface is used to report problems with binding a breakpoint.

## Notes for Callers
 A call to [GetErrorBreakpoint](../../../extensibility/debugger/reference/idebugbreakpointerrorevent2-geterrorbreakpoint.md) obtains this interface. This interface can also be returned (as part of a list represented by an [IEnumDebugErrorBreakpoints2](../../../extensibility/debugger/reference/ienumdebugerrorbreakpoints2.md) interface) by a call to [CanBind](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-canbind.md) or [EnumErrorBreakpoints](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-enumerrorbreakpoints.md).

## Methods in Vtable Order
 The following table shows the methods of `IDebugErrorBreakpoint2`.

|Method|Description|
|------------|-----------------|
|[GetPendingBreakpoint](../../../extensibility/debugger/reference/idebugerrorbreakpoint2-getpendingbreakpoint.md)|Gets the pending breakpoint that caused the error.|
|[GetBreakpointResolution](../../../extensibility/debugger/reference/idebugerrorbreakpoint2-getbreakpointresolution.md)|Gets the breakpoint error resolution that describes the error.|

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [IDebugBreakpointErrorEvent2](../../../extensibility/debugger/reference/idebugbreakpointerrorevent2.md)
- [GetErrorBreakpoint](../../../extensibility/debugger/reference/idebugbreakpointerrorevent2-geterrorbreakpoint.md)
- [IEnumDebugErrorBreakpoints2](../../../extensibility/debugger/reference/ienumdebugerrorbreakpoints2.md)
- [Next](../../../extensibility/debugger/reference/ienumdebugerrorbreakpoints2-next.md)
- [IDebugPendingBreakpoint2](../../../extensibility/debugger/reference/idebugpendingbreakpoint2.md)
- [IDebugErrorBreakpointResolution2](../../../extensibility/debugger/reference/idebugerrorbreakpointresolution2.md)
