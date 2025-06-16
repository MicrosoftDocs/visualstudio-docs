---
description: "Returns the next set of elements from the modules enumeration."
title: IEnumDebugModules2::Next
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugModules2::Next
helpviewer_keywords:
- IEnumDebugModules2::Next
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEnumDebugModules2::Next

Returns the next set of elements from the enumeration.

## Syntax

### [C#](#tab/csharp)
```csharp
int Next(
   uint            celt,
   IDebugModule2[] rgelt,
   ref uint        pceltFetched
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Next(
   ULONG           celt,
   IDebugModule2** rgelt,
   ULONG*          pceltFetched
);
```
---

## Parameters
`celt`\
[in] The number of elements to retrieve. Also specifies the maximum size of the `rgelt` array.

`rgelt`\
[in, out] Array of [IDebugModule2](../../../extensibility/debugger/reference/idebugmodule2.md) elements to be filled in.

`pceltFetched`\
[out] Returns the number of elements actually returned in `rgelt`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if fewer than the requested number of elements could be returned; otherwise, returns an error code.

## See also
- [IEnumDebugModules2](../../../extensibility/debugger/reference/ienumdebugmodules2.md)
- [IDebugModule2](../../../extensibility/debugger/reference/idebugmodule2.md)
