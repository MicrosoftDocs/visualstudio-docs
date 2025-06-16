---
description: "This interface is sent by the debug engine (DE) to the session debug manager (SDM) when a property that is associated with a specific document is about to be destroyed."
title: IDebugPropertyDestroyEvent2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPropertyDestroyEvent2
helpviewer_keywords:
- IDebugPropertyDestroyEvent2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugPropertyDestroyEvent2

This interface is sent by the debug engine (DE) to the session debug manager (SDM) when a property that is associated with a specific document is about to be destroyed.

## Syntax

```
IDebugPropertyDestroyEvent2 : IUnknown
```

## Notes for Implementers
 The DE implements this interface to report that a property has been destroyed. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](/cpp/atl/queryinterface) to access the `IDebugEvent2` interface. This interface is implemented if the DE has previously created a property associated with a script; destroying the property removes the associated script from the IDE.

## Notes for Callers
 The DE creates and sends this event object to report a property has been destroyed. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it is attached to the program being debugged.

## Methods in Vtable Order
 The following table shows the method of `IDebugPropertyDestroyEvent2`.

|Method|Description|
|------------|-----------------|
|[GetDebugProperty](../../../extensibility/debugger/reference/idebugpropertydestroyevent2-getdebugproperty.md)|Gets the property to be destroyed.|

## Remarks
 See the Remarks for [IDebugPropertyCreateEvent2](../../../extensibility/debugger/reference/idebugpropertycreateevent2.md) for details on why these events are used.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
- [IDebugPropertyCreateEvent2](../../../extensibility/debugger/reference/idebugpropertycreateevent2.md)
