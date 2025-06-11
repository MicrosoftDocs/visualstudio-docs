---
description: "This interface is used by the debug engine (DE) to send debug events to the session debug manager (SDM)."
title: IDebugEventCallback2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEventCallback2
helpviewer_keywords:
- IDebugEventCallback2
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugEventCallback2

This interface is used by the debug engine (DE) to send debug events to the session debug manager (SDM).

## Syntax

```
IDebugEventCallback2 : IUnknown
```

## Notes for Implementers
 Visual Studio implements this interface to receive events from a debug engine.

## Notes for Callers
 A debug engine typically receives this interface when the SDM calls [Attach](../../../extensibility/debugger/reference/idebugprogram2-attach.md), [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md), or [LaunchSuspended](../../../extensibility/debugger/reference/idebugenginelaunch2-launchsuspended.md). A debug engine sends events to the SDM by calling [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md).

## Methods in Vtable Order
 The following table shows the methods of `IDebugEventCallback2`.

|Method|Description|
|------------|-----------------|
|[Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md)|Sends notification of debugging events to the SDM.|

## Remarks
 Although [EvaluateSync](../../../extensibility/debugger/reference/idebugexpression2-evaluatesync.md) and [EvaluateAsync](../../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md) specify that they take an `IDebugEventCallback2` interface, this is not the case, and the interface pointer will always be a null value. Instead, the debug engine must use the `IDebugEventCallback2` interface received in the call to [Attach](../../../extensibility/debugger/reference/idebugprogram2-attach.md), [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md), or [LaunchSuspended](../../../extensibility/debugger/reference/idebugenginelaunch2-launchsuspended.md).

 If a package implements [IDebugEventCallback](../../../extensibility/debugger/reference/idebugeventcallback2.md) in managed code, it is strongly advised that <xref:System.Runtime.InteropServices.Marshal.ReleaseComObject%2A> be invoked on the various interfaces that are passed to [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md).

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [LaunchSuspended](../../../extensibility/debugger/reference/idebugenginelaunch2-launchsuspended.md)
- [Attach](../../../extensibility/debugger/reference/idebugprogram2-attach.md)
- [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md)
