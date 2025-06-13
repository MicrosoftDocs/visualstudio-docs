---
description: "This interface enumerates port suppliers."
title: IEnumDebugPortSuppliers2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugPortSuppliers2
helpviewer_keywords:
- IEnumDebugPortSuppliers2
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IEnumDebugPortSuppliers2

This interface enumerates port suppliers.

## Syntax

```
IEnumDebugPortSuppliers2 : IUnknown
```

## Notes for Implementers
 Visual Studio implements this interface to represent a list of port suppliers.

## Notes for Callers
 Call [EnumPortSuppliers](../../../extensibility/debugger/reference/idebugcoreserver2-enumportsuppliers.md) to obtain a list of port suppliers.

## Methods in Vtable Order
 The following table shows the methods of `IEnumDebugPortSuppliers2`.

|Method|Description|
|------------|-----------------|
|[Next](../../../extensibility/debugger/reference/ienumdebugportsuppliers2-next.md)|Retrieves a specified number of port suppliers in an enumeration sequence.|
|[Skip](../../../extensibility/debugger/reference/ienumdebugportsuppliers2-skip.md)|Skips a specified number of port suppliers in an enumeration sequence.|
|[Reset](../../../extensibility/debugger/reference/ienumdebugportsuppliers2-reset.md)|Resets an enumeration sequence to the beginning.|
|[Clone](../../../extensibility/debugger/reference/ienumdebugportsuppliers2-clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|
|[GetCount](../../../extensibility/debugger/reference/ienumdebugportsuppliers2-getcount.md)|Gets the number of port suppliers in an enumerator.|

## Remarks
 A debug engine generally does not need to obtain this interface.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [EnumPortSuppliers](../../../extensibility/debugger/reference/idebugcoreserver2-enumportsuppliers.md)
