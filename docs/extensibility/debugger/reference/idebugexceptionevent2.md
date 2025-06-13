---
description: "The debug engine (DE) sends this interface to the session debug manager (SDM) when an exception is thrown in the program currently being executed."
title: IDebugExceptionEvent2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugExceptionEvent2
helpviewer_keywords:
- IDebugExceptionEvent2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugExceptionEvent2

The debug engine (DE) sends this interface to the session debug manager (SDM) when an exception is thrown in the program currently being executed.

## Syntax

```
IDebugExceptionEvent2 : IUnknown
```

## Notes for Implementers
 The DE implements this interface to report that an exception has occurred in the program being debugged. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](/cpp/atl/queryinterface) to access the `IDebugEvent2` interface.

## Notes for Callers
 The DE creates and sends this event object to report an exception. The event is sent using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged.

## Methods in Vtable Order
 The following table shows the methods of `IDebugExceptionEvent2`.

|Method|Description|
|------------|-----------------|
|[GetException](../../../extensibility/debugger/reference/idebugexceptionevent2-getexception.md)|Gets detailed information about the exception that fired this event.|
|[GetExceptionDescription](../../../extensibility/debugger/reference/idebugexceptionevent2-getexceptiondescription.md)|Gets a human-readable description for the exception thrown that fired this event.|
|[CanPassToDebuggee](../../../extensibility/debugger/reference/idebugexceptionevent2-canpasstodebuggee.md)|Determines whether or not the debug engine (DE) supports the option of passing this exception to the program being debugged when execution resumes.|
|[PassToDebuggee](../../../extensibility/debugger/reference/idebugexceptionevent2-passtodebuggee.md)|Specifies whether the exception should be passed on to the program being debugged when execution resumes, or if the exception should be discarded.|

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## Remarks
 Before sending the event, the DE checks to see if this exception event has been designated a first-chance or second-chance exception by a previous call to [SetException](../../../extensibility/debugger/reference/idebugengine2-setexception.md). If it has been designated to be a first-chance exception, the `IDebugExceptionEvent2` event is sent to the SDM. If not, the DE gives the application a chance to handle the exception. If no exception handler is provided, and if the exception has been designated as a second-chance exception, the `IDebugExceptionEvent2` event is sent to the SDM. Otherwise, the DE resumes execution of the program, and the operating system or runtime handles the exception.

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [SetException](../../../extensibility/debugger/reference/idebugengine2-setexception.md)
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
