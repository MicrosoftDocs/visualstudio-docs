---
title: "IEnumDebugReferenceInfo2::Reset | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEnumDebugReferenceInfo2::Reset"
helpviewer_keywords:
  - "IEnumDebugReferenceInfo2::Reset"
ms.assetid: cf8ce649-5ce1-44a6-9d5a-89760021bde4
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEnumDebugReferenceInfo2::Reset
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
 After this method is called, the next call to the [Next](../../../extensibility/debugger/reference/ienumdebugreferenceinfo2-next.md) method returns the first element of the enumeration.

## See also
- [IEnumDebugReferenceInfo2](../../../extensibility/debugger/reference/ienumdebugreferenceinfo2.md)