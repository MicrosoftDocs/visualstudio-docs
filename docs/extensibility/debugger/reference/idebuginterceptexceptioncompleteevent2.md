---
description: "This interface is sent by the debug engine (DE) to the session debug manager (SDM) when the DE has completed the handling of an intercepted event."
title: IDebugInterceptExceptionCompleteEvent2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugInterceptExceptionCompleteEvent2
helpviewer_keywords:
- IDebugInterceptExceptionCompleteEvent2
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugInterceptExceptionCompleteEvent2

This interface is sent by the debug engine (DE) to the session debug manager (SDM) when the DE has completed the handling of an intercepted event.

## Syntax

```
IDebugInterceptExceptionCompleteEvent2 : IUnknown
```

## Notes for Implementers
 The DE implements this interface to report that processing of an intercepted exception has been completed. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](/cpp/atl/queryinterface) to access the `IDebugEvent2` interface.

## Notes for Callers
 The DE creates and sends this event object to report the completion of an intercepted exception. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged.

## Methods in Vtable Order
 The `IDebugInterceptExceptionCompleteEvent2` interface implements the following methods.

|Method|Description|
|------------|-----------------|
|[GetInterceptCookie](../../../extensibility/debugger/reference/idebuginterceptexceptioncompleteevent2-getinterceptcookie.md)|Returns the unique value associated with the handled exception.|

## Remarks
 This event will be sent by [InterceptCurrentException](../../../extensibility/debugger/reference/idebugstackframe3-interceptcurrentexception.md) when that method has successfully completed handling an intercepted exception.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [InterceptCurrentException](../../../extensibility/debugger/reference/idebugstackframe3-interceptcurrentexception.md)
