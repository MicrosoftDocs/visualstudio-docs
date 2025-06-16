---
description: "This method returns a copy of the current fields enumeration as a separate object."
title: IEnumDebugFields::Clone
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugFields::Clone
helpviewer_keywords:
- IEnumDebugFields::Clone method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEnumDebugFields::Clone

This method returns a copy of the current enumeration as a separate object.

## Syntax

### [C#](#tab/csharp)
```csharp
int Clone(
   out IEnumDebugFields ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Clone(
   IEnumDebugFields** ppEnum
);
```
---

## Parameters
`ppEnum`\
[out] Returns a copy of this enumeration as a separate object.

## Property Value/Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The copy of the enumeration has the same state as the original at the time this method is called. However, the copy's and the original's states are separate and can be changed individually.

## See also
- [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md)
