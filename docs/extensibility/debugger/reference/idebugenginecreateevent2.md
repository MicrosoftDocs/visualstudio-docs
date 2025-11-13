---
description: "The debug engine (DE) sends this interface to the session debug manager (SDM) when an instance of the DE is created."
title: IDebugEngineCreateEvent2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngineCreateEvent2
helpviewer_keywords:
- IDebugEngineCreateEvent2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugEngineCreateEvent2

The debug engine (DE) sends this interface to the session debug manager (SDM) when an instance of the DE is created.

## Syntax

```
IDebugEngineCreateEvent2 : IUnknown
```

## Notes for Implementers
 The DE implements this interface as part of its normal operations. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface (the SDM uses the `QueryInterface` method to access the `IDebugEvent2` interface).

## Notes for Callers
 The DE creates and sends this event object when the DE has been instantiated. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged.

## Methods in Vtable Order
 The following table shows the methods of `IDebugEngineCreateEvent2`.

|Method|Description|
|------------|-----------------|
|[GetEngine](../../../extensibility/debugger/reference/idebugenginecreateevent2-getengine.md)|Retrieves the object that represents the newly created debug engine (DE).|

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
