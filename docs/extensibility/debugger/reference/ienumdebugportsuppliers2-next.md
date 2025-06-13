---
description: "Returns the next set of elements from the port suppliers enumeration."
title: IEnumDebugPortSuppliers2::Next
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugPortSuppliers2::Next
helpviewer_keywords:
- IEnumDebugPortSuppliers2::Next
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEnumDebugPortSuppliers2::Next

Returns the next set of elements from the enumeration.

## Syntax

### [C#](#tab/csharp)
```csharp
int Next(
   uint                  celt,
   IDebugPortSupplier2[] rgelt,
   ref uint              pceltFetched
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Next(
   ULONG                 celt,
   IDebugPortSupplier2** rgelt,
   ULONG*                pceltFetched
);
```
---

## Parameters
`celt`\
[in] The number of elements to retrieve. Also specifies the maximum size of the `rgelt` array.

`rgelt`\
[in, out] Array of [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md) elements to be filled in.

`pceltFetched`\
[out] Returns the number of elements actually returned in `rgelt`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if fewer than the requested number of elements could be returned; otherwise, returns an error code.

## See also
- [IEnumDebugPortSuppliers2](../../../extensibility/debugger/reference/ienumdebugportsuppliers2.md)
- [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md)
