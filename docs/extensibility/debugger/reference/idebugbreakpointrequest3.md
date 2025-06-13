---
description: "The IDebugBreakpointRequest3 interface represents the information necessary to create and bind any type of breakpoint."
title: IDebugBreakpointRequest3
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBreakpointRequest3
helpviewer_keywords:
- IDebugBreakpointRequest3
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugBreakpointRequest3

This interface represents the information necessary to create and bind any type of breakpoint. It is an extension of [IDebugBreakpointRequest2](../../../extensibility/debugger/reference/idebugbreakpointrequest2.md).

## Syntax

```
IDebugBreakpointRequest3 : IDebugBreakpointRequest2
```

## Notes for Implementers
 The session debug manager (SDM) typically implements this interface.

## Notes for Callers
 The debug engine (DE) accesses this interface by calling [QueryInterface](/cpp/atl/queryinterface) on the IDebugBreakpointRequest2 interface received in a call to [CreatePendingBreakpoint](../../../extensibility/debugger/reference/idebugengine2-creatependingbreakpoint.md).

## Methods in Vtable Order
 In addition to the methods inherited from [IDebugBreakpointRequest2](../../../extensibility/debugger/reference/idebugbreakpointrequest2.md), the `IDebugBreakpointRequest3` interface exposes the following method.

|Method|Description|
|------------|-----------------|
|[GetRequestInfo2](../../../extensibility/debugger/reference/idebugbreakpointrequest3-getrequestinfo2.md)|Gets the breakpoint request information that describes this breakpoint request.|

## Remarks
 This interface is used to provide additional information to the DE through the [BP_REQUEST_INFO2](../../../extensibility/debugger/reference/bp-request-info2.md) structure. This additional information includes the DE's vendor ID (in the form of a GUID), the name of a tracepoint, and the name of a breakpoint constraint.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [IDebugBreakpointRequest2](../../../extensibility/debugger/reference/idebugbreakpointrequest2.md)
- [BP_REQUEST_INFO2](../../../extensibility/debugger/reference/bp-request-info2.md)
