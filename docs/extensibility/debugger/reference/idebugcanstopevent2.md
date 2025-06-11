---
description: "This interface is used to ask the session debug manager (SDM) whether to stop at the current code location."
title: IDebugCanStopEvent2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCanStopEvent2
helpviewer_keywords:
- IDebugBreakpointRequest2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugCanStopEvent2

This interface is used to ask the session debug manager (SDM) whether to stop at the current code location.

## Syntax

```
IDebugCanStopEvent2 : IUknown
```

## Notes for Implementers
 The debug engine (DE) implements this interface to support stepping through source code. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface (the SDM uses [QueryInterface](/cpp/atl/queryinterface) to access the `IDebugEvent2` interface).

 The implementation of this interface must communicate the SDM's call of [CanStop](../../../extensibility/debugger/reference/idebugcanstopevent2-canstop.md) to the debug engine. For example, this can be done with a message posted to the debug engine's message handling thread or the object implementing this interface could hold a reference to the debug engine and call back into the debug engine with the flag passed into `IDebugCanStopEvent2::CanStop`.

## Notes for Callers
 The DE can send this method each time the DE is asked to continue execution and the DE is stepping through code. This event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function supplied by the SDM when it attached to the program being debugged.

## Methods in Vtable Order
 The following table shows the methods of `IDebugCanStopEvent2`.

|Method|Description|
|------------|-----------------|
|[GetReason](../../../extensibility/debugger/reference/idebugcanstopevent2-getreason.md)|Gets the reason for this event.|
|[CanStop](../../../extensibility/debugger/reference/idebugcanstopevent2-canstop.md)|Specifies whether the program being debugged should stop at the location of this event (and send an event that describes the reason for stopping) or just continue execution.|
|[GetDocumentContext](../../../extensibility/debugger/reference/idebugcanstopevent2-getdocumentcontext.md)|Gets the document context that describes the location of this event.|
|[GetCodeContext](../../../extensibility/debugger/reference/idebugcanstopevent2-getcodecontext.md)|Gets the code context that describes the location of this event.|

## Remarks
 The DE sends this interface if the user steps into a function and the DE finds no debug information there or debug information exists but the DE does not know if the source code can be displayed for that location.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [IDebugStepCompleteEvent2](../../../extensibility/debugger/reference/idebugstepcompleteevent2.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
