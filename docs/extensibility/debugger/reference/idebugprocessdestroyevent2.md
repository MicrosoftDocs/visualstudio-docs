---
description: "This interface is sent when a process is terminated, exits atypically, or is detached from."
title: IDebugProcessDestroyEvent2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProcessDestroyEvent2
helpviewer_keywords:
- IDebugProcessDestroyEvent2
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugProcessDestroyEvent2

This interface is sent when a process is terminated, exits atypically, or is detached from.

## Syntax

```
IDebugProcessDestroyEvent2 : IUnknown
```

## Notes for Implementers
 The debug engine (DE) or the custom port supplier implement this interface to report that a process has been terminated. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](/cpp/atl/queryinterface) to access the `IDebugEvent2` interface.

## Notes for Callers
 The DE or the custom port supplier creates and sends this event object to report the termination of a process. The DE sends this event by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it is attached to the program being debugged. The custom port supplier sends this event using the [IDebugPortEvents2](../../../extensibility/debugger/reference/idebugportevents2.md) interface.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
- [IDebugPortEvents2](../../../extensibility/debugger/reference/idebugportevents2.md)
