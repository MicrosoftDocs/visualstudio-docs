---
description: "Gets the rank of the array, that is, the number of dimensions."
title: IDebugArrayObject::GetRank | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugArrayObject::GetRank
helpviewer_keywords:
- IDebugArrayObject::GetRank method
ms.assetid: 9948551a-e334-4ff6-979c-08dab633b9b6
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugArrayObject::GetRank

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
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
