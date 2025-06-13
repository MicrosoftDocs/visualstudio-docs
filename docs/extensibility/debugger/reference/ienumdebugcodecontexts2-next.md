---
description: "Returns the next set of elements from the code contexts enumeration."
title: IEnumDebugCodeContexts2::Next
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugCodeContexts2::Next
helpviewer_keywords:
- IEnumDebugCodeContexts2::Next
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEnumDebugCodeContexts2::Next

Returns the next set of elements from the enumeration.

## Syntax

### [C#](#tab/csharp)
```csharp
int Next(
   uint                 celt,
   IDebugCodeContext2[] rgelt,
   ref uint             pceltFetched
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Next(
   ULONG                celt,
   IDebugCodeContext2** rgelt,
   ULONG*               pceltFetched
);
```
---

## Parameters
`celt`\
[in] The number of elements to retrieve. Also specifies the maximum size of the `rgelt` array.

`rgelt`\
[in, out] Array of [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md) elements to be filled in.

`pceltFetched`\
[out] Returns the number of elements actually returned in `rgelt`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if fewer than the requested number of elements could be returned; otherwise, returns an error code.

## See also
- [IEnumDebugCodeContexts2](../../../extensibility/debugger/reference/ienumdebugcodecontexts2.md)
- [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md)
