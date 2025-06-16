---
description: "Gets the rank of the array, that is, the number of dimensions."
title: IDebugArrayObject::GetRank
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugArrayObject::GetRank
helpviewer_keywords:
- IDebugArrayObject::GetRank method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugArrayObject::GetRank

Gets the rank of the array, that is, the number of dimensions.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetRank(
   out uint pdwRank
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetRank( 
   DWORD* pdwRank
);
```
---

## Parameters
`pdwRank`\
[out] Returns the rank.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 Use the [GetDimensions](../../../extensibility/debugger/reference/idebugarrayobject-getdimensions.md) method to retrieve the size of each dimension of the array object.

## See also
- [IDebugArrayObject](../../../extensibility/debugger/reference/idebugarrayobject.md)
