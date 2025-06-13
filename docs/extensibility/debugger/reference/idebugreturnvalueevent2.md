---
description: "This interface is sent by the debug engine (DE) to the session debug manager (SDM) after stepping out of or over a function."
title: IDebugReturnValueEvent2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugReturnValueEvent2
helpviewer_keywords:
- IDebugReturnValueEvent2
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugReturnValueEvent2

This interface is sent by the debug engine (DE) to the session debug manager (SDM) after stepping out of or over a function.

## Syntax

```
IDebugReturnValueEvent2 : IUnknown
```

## Notes for Implementers
 The DE implements this interface to report the return value from a function that has been stepped out of or over. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](/cpp/atl/queryinterface) to access the `IDebugEvent2` interface.

## Notes for Callers
 The DE creates and sends this event object to report the return value of a function. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it is attached to the program being debugged.

## Methods in Vtable Order
 The following table shows the method of `IDebugReturnValueEvent2`.

|Method|Description|
|------------|-----------------|
|[GetReturnValue](../../../extensibility/debugger/reference/idebugreturnvalueevent2-getreturnvalue.md)|Gets the value returned on stepping out of a function.|

## Remarks
 The value returned by a function can be obtained by calling [GetReturnValue](../../../extensibility/debugger/reference/idebugreturnvalueevent2-getreturnvalue.md). The value returned appears in the **Autos** window.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
