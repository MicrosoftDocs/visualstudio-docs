---
description: "This interface is sent by the debug engine (DE) to the session debug manager (SDM) when a program is loaded, but before any code is executed."
title: IDebugLoadCompleteEvent2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugLoadCompleteEvent2
helpviewer_keywords:
- IDebugLoadCompleteEvent2
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugLoadCompleteEvent2

This interface is sent by the debug engine (DE) to the session debug manager (SDM) when a program is loaded, but before any code is executed.

## Syntax

```
IDebugLoadCompleteEvent2 : IUnknown
```

## Notes for Implementers
 The DE implements this interface to report that a program has been successfully loaded. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](/cpp/atl/queryinterface) to access the `IDebugEvent2` interface.

## Notes for Callers
 The DE creates and sends this event object to report that a program has been successfully loaded. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
