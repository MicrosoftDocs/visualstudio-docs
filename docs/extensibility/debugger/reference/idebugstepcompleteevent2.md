---
title: "IDebugStepCompleteEvent2 | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugStepCompleteEvent2"
helpviewer_keywords:
  - "IDebugStepCompleteEvent2 interface"
ms.assetid: eba2b76e-f90d-486b-ae5c-c47f1b8ba2e5
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
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