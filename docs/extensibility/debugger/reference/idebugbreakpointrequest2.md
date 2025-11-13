---
description: "The IDebugBreakPointRequest2 interface represents the information necessary to create and bind any type of breakpoint."
title: IDebugBreakpointRequest2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBreakpointRequest2
helpviewer_keywords:
- IDebugBreakpointRequest2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugBreakpointRequest2

This interface represents the information necessary to create and bind any type of breakpoint.

## Syntax

```
IDebugBreakpointRequest2 : IUnknown
```

## Notes for Implementers
 The session debug manager (SDM) typically implements this interface.

## Notes for Callers
 The debug engine (DE) receives this interface through a call to [CreatePendingBreakpoint](../../../extensibility/debugger/reference/idebugengine2-creatependingbreakpoint.md) in order to create a pending breakpoint. A call to [GetBreakpointRequest](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-getbreakpointrequest.md) can retrieve this interface from the DE.

## Methods in Vtable Order
 The following table shows the methods of `IDebugBreakpointRequest2`.

|Method|Description|
|------------|-----------------|
|[GetLocationType](../../../extensibility/debugger/reference/idebugbreakpointrequest2-getlocationtype.md)|Gets the breakpoint location type of this breakpoint request.|
|[GetRequestInfo](../../../extensibility/debugger/reference/idebugbreakpointrequest2-getrequestinfo.md)|Gets the breakpoint request information that describes this breakpoint request.|

## Remarks
 After the program being debugged has been loaded, a call to [Bind](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-bind.md) binds a pending breakpoint to the requested location in the program.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [CreatePendingBreakpoint](../../../extensibility/debugger/reference/idebugengine2-creatependingbreakpoint.md)
- [GetBreakpointRequest](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-getbreakpointrequest.md)
- [Bind](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-bind.md)
