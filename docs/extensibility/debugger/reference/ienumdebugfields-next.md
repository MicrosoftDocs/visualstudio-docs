---
description: "This method returns the next set of elements from the fields enumeration."
title: IEnumDebugFields::Next
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugFields::Next
helpviewer_keywords:
- IEnumDebugFields::Next method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEnumDebugFields::Next

This method returns the next set of elements from the enumeration.

## Syntax

### [C#](#tab/csharp)
```csharp
int Next(
   uint          celt,
   IDebugField[] rgelt,
   ref uint      pceltFetched
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Next(
   ULONG         celt,
   IDebugField** rgelt,
   ULONG*        pceltFetched
);
```
---

## Parameters
`celt`\
[in] The number of elements to retrieve. Also specifies the maximum size of the `rgelt` array.

`rgelt`\
[in, out] Array of [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) elements to be filled in.

`pceltFetched`\
[out] Returns the number of elements actually returned in `rgelt`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if fewer than the requested number of elements could be returned; otherwise, returns an error code.

## See also
- [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
