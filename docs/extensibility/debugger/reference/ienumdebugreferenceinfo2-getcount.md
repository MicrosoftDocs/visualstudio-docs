---
description: "Returns the number of DEBUG_REFERENCE_INFO elements in the enumeration."
title: IEnumDebugReferenceInfo2::GetCount
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugReferenceInfo2::GetCount
helpviewer_keywords:
- IEnumDebugReferenceInfo2::GetCount
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEnumDebugReferenceInfo2::GetCount

Returns the number of elements in the enumeration.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetCount(
   out uint pcelt
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetCount(
   ULONG* pcelt
);
```
---

## Parameters
`pcelt`\
[out] Returns the number of elements in the enumeration.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is not part of the customary COM enumeration interface which specifies that only the `Next`, `Clone`, `Skip`, and `Reset` methods need to be implemented.

## See also
- [IEnumDebugReferenceInfo2](../../../extensibility/debugger/reference/ienumdebugreferenceinfo2.md)
