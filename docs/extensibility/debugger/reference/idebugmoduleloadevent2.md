---
description: "This interface is sent by the debug engine (DE) to the session debug manager (SDM) when a module is loaded or unloaded."
title: IDebugModuleLoadEvent2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugModuleLoadEvent2
helpviewer_keywords:
- IDebugModuleLoadEvent2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugModuleLoadEvent2

This interface is sent by the debug engine (DE) to the session debug manager (SDM) when a module is loaded or unloaded.

## Syntax

```
IDebugModuleLoadEvent2 : IUnknown
```

## Notes for Implementers
 The DE implements this interface to report that a module has been loaded or unloaded. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](/cpp/atl/queryinterface) to access the `IDebugEvent2` interface.

## Notes for Callers
 The DE creates and sends this event object to report a module has been loaded or unloaded. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it is attached to the program being debugged.

## Methods in Vtable Order
 The following table shows the method of `IDebugModuleLoadEvent2`.

|Method|Description|
|------------|-----------------|
|[GetModule](../../../extensibility/debugger/reference/idebugmoduleloadevent2-getmodule.md)|Gets the module that is being loaded or unloaded.|

## Remarks
 Visual Studio uses this event to keep the **Modules** window up to date.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
