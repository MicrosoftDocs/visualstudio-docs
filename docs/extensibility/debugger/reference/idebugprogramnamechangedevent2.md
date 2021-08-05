---
description: "Sent from the debug engine (DE) to the session debug manager (SDM) when the name of a program changes."
title: IDebugProgramNameChangedEvent2 | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugProgramNameChangedEvent2 interface
ms.assetid: be1f1cd5-0b2f-435c-a052-dca28a7c978d
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
---
# IDebugProgramNameChangedEvent2
Sent from the debug engine (DE) to the session debug manager (SDM) when the name of a program changes.

## Syntax

```
IDebugProgramNameChangedEvent2 : IUnknown
```

## Notes for Implementers
 The DE implements this interface to report that the name of the program has changed. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](/cpp/atl/queryinterface) to access the **IDebugEvent2** interface.

## Notes for Callers
 The DE creates and sends this event object to report a program name change. The DE sends this event by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged. The custom port supplier sends this event using the I interface.

## Requirements
 Header: Msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
