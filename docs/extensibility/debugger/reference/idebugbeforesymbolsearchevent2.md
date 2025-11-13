---
description: "The debug engine (DE) sends this interface to the session debug manager (SDM) to set the status bar message during symbol loads."
title: IDebugBeforeSymbolSearchEvent2
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugBeforeSymbolSearchEvent2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugBeforeSymbolSearchEvent2

The debug engine (DE) sends this interface to the session debug manager (SDM) to set the status bar message during symbol loads.

## Syntax

```
IDebugBeforeSymbolSearchEvent2 : IUnknown
```

## Notes for Implementers
 The DE implements this interface when it must set the status bar message during symbol loads. This interface is implemented only by debug engines that work with or are a part of script interpreters. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface (the SDM uses **QueryInterface** to access the **IDebugEvent2** interface).

## Notes for Callers
 The DE creates and sends this event object when it must set the status bar message during symbol loads. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function supplied by the SDM when it attached to the program being debugged.

## Methods
 The following table shows the methods of `IDebugBeforeSymbolSearchEvent2`.

|Method|Description|
|------------|-----------------|
|[GetModuleName](../../../extensibility/debugger/reference/idebugbeforesymbolsearchevent2-getmodulename.md)|Retrieves the name of the module currently being debugged.|

## Requirements
 Header: Msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
