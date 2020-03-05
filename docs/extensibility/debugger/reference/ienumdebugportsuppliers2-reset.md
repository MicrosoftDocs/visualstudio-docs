---
title: "IEnumDebugPortSuppliers2::Reset | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEnumDebugPortSuppliers2::Next"
helpviewer_keywords:
  - "IEnumDebugPortSuppliers2::Next"
ms.assetid: f69cbacf-da9d-4b22-b8a2-abd9b8c131f2
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEnumDebugPortSuppliers2::Reset
Resets the enumeration to the first element.

## Syntax

```cpp
HRESULT Reset(
   void
);
```

```csharp
int Reset();
```

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 After this method is called, the next call to the [Next](../../../extensibility/debugger/reference/ienumdebugportsuppliers2-next.md) method returns the first element of the enumeration.

## See also
- [IEnumDebugPortSuppliers2](../../../extensibility/debugger/reference/ienumdebugportsuppliers2.md)