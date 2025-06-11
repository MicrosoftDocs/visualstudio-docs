---
description: "This interface is sent by the debug engine (DE) to the session debug manager (SDM) when a program is attached to."
title: IDebugProgramCreateEvent2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramCreateEvent2
helpviewer_keywords:
- IDebugProgramCreateEvent2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugProgramCreateEvent2

This interface is sent by the debug engine (DE) to the session debug manager (SDM) when a program is attached to.

## Syntax

```
IDebugProgramCreateEvent2 : IUnknown
```

## Notes for Implementers
 The DE or the custom port supplier implements this interface to report that a program has been created, typically at the time the program is attached to. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses the `QueryInterface` method to access the `IDebugEvent2` interface.

## Notes for Callers
 The DE or the custom port supplier creates and sends this event object to report the creation of a program. The DE sends this event by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged. The custom port supplier sends this event using the [IDebugPortEvents2](../../../extensibility/debugger/reference/idebugportevents2.md) interface.

## Remarks
 The DE or custom port supplier publishes a new [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) interface by calling [PublishProgramNode](../../../extensibility/debugger/reference/idebugprogrampublisher2-publishprogramnode.md).

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
- [IDebugPortEvents2](../../../extensibility/debugger/reference/idebugportevents2.md)
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
