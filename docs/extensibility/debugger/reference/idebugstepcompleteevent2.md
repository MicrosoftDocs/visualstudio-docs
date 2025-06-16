---
description: "This interface is sent by the debug engine (DE) to the session debug manager (SDM) when the program being debugged completes a step into, a step over, or a step out of a line of source code or statement or instruction."
title: IDebugStepCompleteEvent2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugStepCompleteEvent2
helpviewer_keywords:
- IDebugStepCompleteEvent2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugStepCompleteEvent2

This interface is sent by the debug engine (DE) to the session debug manager (SDM) when the program being debugged completes a step into, a step over, or a step out of a line of source code or statement or instruction.

## Syntax

```
IDebugStepCompleteEvent2 : IUnknown
```

## Notes for Implementers
 The DE implements this interface to report the completion of a step operation. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](/cpp/atl/queryinterface) to access the `IDebugEvent2` interface.

## Notes for Callers
 The DE creates and sends this event object to report the completion of a step operation. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it is attached to the program being debugged.

## Remarks
 Once the step has been completed, the program being debugged is paused once more, and the IDE updates all its windows.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
