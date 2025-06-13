---
description: "This interface enumerates the ports of a machine or port supplier."
title: IEnumDebugPorts2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugPorts2
helpviewer_keywords:
- IEnumDebugPorts2
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IEnumDebugPorts2

This interface enumerates the ports of a machine or port supplier.

## Syntax

```
IEnumDebugPorts2 : IUnknown
```

## Notes for Implementers
 A custom port supplier implements this interface to represent a list of ports created by the supplier. Visual Studio implements this interface in support of its own port supplier.

## Notes for Callers
 Call [EnumPorts](../../../extensibility/debugger/reference/idebugportsupplier2-enumports.md) to obtain this interface representing a list of ports created by the port supplier. Call [EnumPersistedPorts](../../../extensibility/debugger/reference/idebugportsupplier3-enumpersistedports.md) to obtain this interface representing a list of ports that were saved to disk.

## Methods in Vtable Order
 The following table shows the methods of `IEnumDebugPorts2`.

|Method|Description|
|------------|-----------------|
|[Next](../../../extensibility/debugger/reference/ienumdebugports2-next.md)|Retrieves a specified number of ports in an enumeration sequence.|
|[Skip](../../../extensibility/debugger/reference/ienumdebugports2-skip.md)|Skips a specified number of ports in an enumeration sequence.|
|[Reset](../../../extensibility/debugger/reference/ienumdebugports2-reset.md)|Resets an enumeration sequence to the beginning.|
|[Clone](../../../extensibility/debugger/reference/ienumdebugports2-clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|
|[GetCount](../../../extensibility/debugger/reference/ienumdebugports2-getcount.md)|Gets the number of ports in an enumerator.|

## Remarks
 Visual Studio uses this interface to help populate a list of ports used for attaching to processes.

 A debug engine typically does not use this interface.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [EnumPorts](../../../extensibility/debugger/reference/idebugcoreserver2-enumports.md)
- [EnumPorts](../../../extensibility/debugger/reference/idebugportsupplier2-enumports.md)
