---
description: "This interface is sent by the debug engine (DE) to indicate that the debugging symbols for a module being debugged have been loaded."
title: IDebugSymbolSearchEvent2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugSymbolSearchEvent2
helpviewer_keywords:
- IDebugSymbolSearchEvent2
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugSymbolSearchEvent2

This interface is sent by the debug engine (DE) to indicate that the debugging symbols for a module being debugged have been loaded.

## Syntax

```
IDebugSymbolSearchEvent2 : IUnknown
```

## Notes for Implementers
 The DE implements this interface to report that a module's symbols have been loaded. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](/cpp/atl/queryinterface) to access the `IDebugEvent2` interface.

## Notes for Callers
 The DE creates and sends this event object to report that a module's symbols have been loaded. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged.

## Methods in Vtable Order
 The `IDebugSymbolSearchEvent2` interface exposes the following method.

|Method|Description|
|------------|-----------------|
|[GetSymbolSearchInfo](../../../extensibility/debugger/reference/idebugsymbolsearchevent2-getsymbolsearchinfo.md)|Retrieves information about the results of a symbol search.|

## Remarks
 This event will be sent even if the symbols failed to load. Calling `IDebugSymbolSearchEvent2::GetSymbolSearchInfo` allows the handler of this event to determine if the module actually has any symbols.

 Visual Studio typically uses this event to update the status of loaded symbols in the **Modules** window.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
