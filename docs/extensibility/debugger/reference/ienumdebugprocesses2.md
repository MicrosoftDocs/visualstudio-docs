---
description: "This interface enumerates the processes running on a debug port."
title: IEnumDebugProcesses2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugProcesses2
helpviewer_keywords:
- IEnumDebugProcesses2
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IEnumDebugProcesses2

This interface enumerates the processes running on a debug port.

## Syntax

```
IEnumDebugProcesses : IUnknown
```

## Notes for Implementers
 A custom port supplier implements this interface to provide a list of processes running on a port.

## Notes for Callers
 Visual Studio calls [EnumProcesses](../../../extensibility/debugger/reference/idebugport2-enumprocesses.md) to obtain this interface.

## Methods in Vtable Order
 The following table shows the methods of `IEnumDebugProcesses2`.

|Method|Description|
|------------|-----------------|
|[Next](../../../extensibility/debugger/reference/ienumdebugprocesses2-next.md)|Retrieves a specified number of processes in an enumeration sequence.|
|[Skip](../../../extensibility/debugger/reference/ienumdebugprocesses2-skip.md)|Skips a specified number of processes in an enumeration sequence.|
|[Reset](../../../extensibility/debugger/reference/ienumdebugprocesses2-reset.md)|Resets an enumeration sequence to the beginning.|
|[Clone](../../../extensibility/debugger/reference/ienumdebugprocesses2-clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|
|[GetCount](../../../extensibility/debugger/reference/ienumdebugprocesses2-getcount.md)|Gets the number of processes in an enumerator.|

## Remarks
 Visual Studio uses this interface to populate the **Processes** window.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [EnumProcesses](../../../extensibility/debugger/reference/idebugport2-enumprocesses.md)
