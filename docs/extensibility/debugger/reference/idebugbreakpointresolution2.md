---
title: "IDebugBreakpointResolution2 | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugBreakpointResolution2"
helpviewer_keywords:
  - "IDebugBreakpointRequest2 interface"
ms.assetid: 451d5bce-b9c1-48ff-beaa-2b4c3e1ceea0
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# IDebugBreakpointResolution2
This interface represents the information that describes a bound breakpoint.

## Syntax

```
IDebugBreakpointResolution2 : IUnknown
```

## Notes for Implementers
 The debug engine (DE) implements this interface as part of its support for breakpoints. This interface provides a description of a bound breakpoint that the session debug manager uses when a user views a breakpoint's properties.

## Notes for Callers
 A call to [GetBreakpointResolution](../../../extensibility/debugger/reference/idebugboundbreakpoint2-getbreakpointresolution.md) returns this interface.

## Methods in Vtable Order
 The following table shows the methods of `IDebugBreakpointResolution2`.

|Method|Description|
|------------|-----------------|
|[GetBreakpointType](../../../extensibility/debugger/reference/idebugbreakpointresolution2-getbreakpointtype.md)|Gets the type of the breakpoint represented by this resolution.|
|[GetResolutionInfo](../../../extensibility/debugger/reference/idebugbreakpointresolution2-getresolutioninfo.md)|Gets the breakpoint resolution information that describes this breakpoint.|

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [GetBreakpointResolution](../../../extensibility/debugger/reference/idebugboundbreakpoint2-getbreakpointresolution.md)