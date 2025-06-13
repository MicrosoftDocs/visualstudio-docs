---
description: "This method returns the next set of elements from the addresses enumeration."
title: IEnumDebugAddresses::Next
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugAddresses::Next
helpviewer_keywords:
- IEnumDebugAddresses::Next method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEnumDebugAddresses::Next

This method returns the next set of elements from the enumeration.

## Syntax

### [C#](#tab/csharp)
```csharp
int Next(
   uint            celt,
   IDebugAddress[] rgelt,
   ref uint        pceltFetched
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Next(
   ULONG           celt,
   IDebugAddress** rgelt,
   ULONG*          pceltFetched
);
```
---

## Parameters
`celt`\
[in] The number of elements to retrieve. Also specifies the maximum size of the `rgelt` array.

`rgelt`\
[in, out] Array of [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) elements to be filled in.

`pceltFetched`\
[out] Returns the number of elements actually returned in `rgelt`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if fewer than the requested number of elements could be returned; otherwise, returns an error code.

## See also
- [IEnumDebugAddresses](../../../extensibility/debugger/reference/ienumdebugaddresses.md)
- [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md)
