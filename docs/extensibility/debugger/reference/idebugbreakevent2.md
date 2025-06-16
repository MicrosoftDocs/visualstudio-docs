---
description: "This interface tells the session debug manager (SDM) that an asynchronous break has been successfully completed."
title: IDebugBreakEvent2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBreakEvent2
helpviewer_keywords:
- IDebugBreakEvent2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugBreakEvent2

This interface tells the session debug manager (SDM) that an asynchronous break has been successfully completed.

## Syntax

```
IDebugBreakEvent2 : IUnknown
```

## Notes for Implementers
 The DE implements this interface to support user breaks in a program. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface (the SDM uses [QueryInterface](/cpp/atl/queryinterface) to access the `IDebugEvent2` interface).

## Notes for Callers
 The SDM calls [CauseBreak](../../../extensibility/debugger/reference/idebugprogram2-causebreak.md) when the user has requested the program being debugged to be paused. When the program has successfully been paused, the DE sends the `IDebugBreakEvent2` event. This event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function supplied by the SDM when it attached to the program being debugged.

## Remarks
 For example, a user can select the **Break All** command on the **Debug** menu to break out of a program that is running an infinite loop. The SDM tells the program to stop by calling [CauseBreak](../../../extensibility/debugger/reference/idebugprogram2-causebreak.md). The DE sends `IDebugBreakEvent2` when the program finally stops.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [CauseBreak](../../../extensibility/debugger/reference/idebugprogram2-causebreak.md)
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
