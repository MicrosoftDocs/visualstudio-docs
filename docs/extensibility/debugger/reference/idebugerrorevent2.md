---
description: "This interface specifies an error message to be reported to the user."
title: IDebugErrorEvent2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugErrorEvent2
helpviewer_keywords:
- IDebugErrorEvent2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugErrorEvent2

This interface specifies an error message to be reported to the user.

## Syntax

```
IDebugErrorEvent2 : IUnknown
```

## Notes for Implementers
 The debug engine (DE) implements this interface to report errors as human-readable messages. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM  uses [QueryInterface](/cpp/atl/queryinterface) to access the `IDebugEvent2` interface.

## Notes for Callers
 The DE creates and sends this event object to report an error. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged.

## Methods in Vtable order
 This interface implements the following method:

|Method|Description|
|------------|-----------------|
|`GetErrorMessage`|Returns an error as a human-readable string.|

## Remarks
 If the debug engine encounters an error, it can use this interface to report the message through Visual Studio to the user.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
