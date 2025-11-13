---
description: "Gets the rank or number of dimensions of the array."
title: IDebugArrayField::GetRank
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugArrayField::GetRank
helpviewer_keywords:
- IDebugArrayField::GetRank method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugArrayField::GetRank

Gets the rank or number of dimensions of the array.

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
 The rank of an array corresponds to the number of dimensions. In C++ and C#, multi-dimensional arrays are really arrays of arrays and can therefore be considered just a one-dimensional array (and the `GetRank` method always returns 1). In Visual Basic, on the other hand, multi-dimensional arrays are handled differently and the rank of such an array reflects the number of dimensions (and the `GetRank` method always returns the number of dimensions).

## See also
- [IDebugArrayField](../../../extensibility/debugger/reference/idebugarrayfield.md)
