---
description: "Gets the number of elements in the array."
title: IDebugArrayField::GetNumberOfElements
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugArrayField::GetNumberOfElements
helpviewer_keywords:
- IDebugArrayField::GetNumberOfElements method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugArrayField::GetNumberOfElements

Gets the number of elements in the array.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetNumberOfElements(
   out uint pdwNumElements
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetNumberOfElements( 
   DWORD* pdwNumElements
);
```
---

## Parameters
`pdwNumElements`\
[out] Returns the number of elements in the array.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 The value returned is the total number of elements in the array, regardless of the number of dimensions.

## See also
- [IDebugArrayField](../../../extensibility/debugger/reference/idebugarrayfield.md)
