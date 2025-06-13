---
description: "This method skips over the specified number of elements in the addresses enumeration."
title: IEnumDebugAddresses::Skip
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugAddresses::Skip
helpviewer_keywords:
- IEnumDebugAddresses::Skip method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEnumDebugAddresses::Skip

This method skips over the specified number of elements.

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
   [in] ULONG celt
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
- [IEnumDebugAddresses](../../../extensibility/debugger/reference/ienumdebugaddresses.md)
