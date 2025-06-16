---
description: "Returns a copy of the current threads enumeration as a separate object."
title: IEnumDebugThreads2::Clone
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugThreads2::Clone
helpviewer_keywords:
- IEnumDebugThreads2::Clone
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEnumDebugThreads2::Clone

Returns a copy of the current enumeration as a separate object.

## Syntax

### [C#](#tab/csharp)
```csharp
int Clone(
   out IEnumDebugThreads2 ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Clone(
   IEnumDebugThreads2** ppEnum
);
```
---

## Parameters
`ppEnum`\
[out] Returns a copy of this enumeration as a separate object.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The copy of the enumeration has the same state as the original at the time this method is called. However, the copy's and the original's states are separate and can be changed individually.

## See also
- [IEnumDebugThreads2](../../../extensibility/debugger/reference/ienumdebugthreads2.md)
