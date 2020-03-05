---
title: "IEnumCodePaths2::Reset | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEnumCodePaths2::Reset"
helpviewer_keywords:
  - "IEnumCodePaths2::Reset"
ms.assetid: 490c0e19-ff4b-4673-bd06-cdee996ac226
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEnumCodePaths2::Reset
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
 After this method is called, the next call to the [Next](../../../extensibility/debugger/reference/ienumcodepaths2-next.md) method returns the first element of the enumeration.

## See also
- [IEnumCodePaths2](../../../extensibility/debugger/reference/ienumcodepaths2.md)