---
description: "Retrieves the address of the pointer."
title: IDebugPointerObject3::GetPointerAddress
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- GetPointerAddress
- IDebugPointerObject3::GetPointerAddress
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPointerObject3::GetPointerAddress

Retrieves the address of the pointer.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetPointerAddress (
   out ulong puAddress
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetPointerAddress (
   UINT64* puAddress
);
```
---

## Parameters
`puAddress`
[out] Returns the address of the pointer.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPointerObject3](../../../extensibility/debugger/reference/idebugpointerobject3.md)
