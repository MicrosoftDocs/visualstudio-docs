---
description: "Skips over the specified number of DEBUG_PROPERTY_INFO elements."
title: IEnumDebugPropertyInfo2::Skip
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugPropertyInfo2::Skip
helpviewer_keywords:
- IEnumDebugPropertyInfo2::Skip
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEnumDebugPropertyInfo2::Skip

Skips over the specified number of elements.

## Syntax

### [C#](#tab/csharp)
```csharp
int Skip(
   uint celt
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Skip(
   ULONG celt
);
```
---

## Parameters
`celt`\
[in] Number of elements to skip.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if `celt` is greater than the number of remaining elements; otherwise, returns an error code.

## Remarks
 If `celt` specifies a value greater than the number of remaining elements, the enumeration is set to the end and `S_FALSE` is returned.

## See also
- [IEnumDebugPropertyInfo2](../../../extensibility/debugger/reference/ienumdebugpropertyinfo2.md)
