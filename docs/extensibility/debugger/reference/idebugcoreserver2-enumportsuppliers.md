---
title: "IDebugCoreServer2::EnumPortSuppliers | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugCoreServer2::EnumPortSuppliers"
helpviewer_keywords:
  - "IDebugCoreServer2::EnumPortSuppliers"
ms.assetid: ce0c90e4-8e02-4b08-b558-7677fb2c88f7
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugCoreServer2::EnumPortSuppliers
Retrieves a list of all available port suppliers.

## Syntax

```cpp
HRESULT EnumPortSuppliers(
   IEnumDebugPortSuppliers2** ppEnum
);
```

```csharp
int EnumPortSuppliers(
   out IEnumDebugPortSuppliers2 ppEnum
);
```

## Parameters
`ppEnum`\
[out] Returns an [IEnumDebugPortSuppliers2](../../../extensibility/debugger/reference/ienumdebugportsuppliers2.md) object that contains a list of all port suppliers.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugCoreServer2](../../../extensibility/debugger/reference/idebugcoreserver2.md)
- [IEnumDebugPortSuppliers2](../../../extensibility/debugger/reference/ienumdebugportsuppliers2.md)