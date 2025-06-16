---
description: "Gets the count of elements in the array."
title: IDebugArrayObject::GetCount
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugArrayObject::GetCount
helpviewer_keywords:
- IDebugArrayObject::GetCount method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugArrayObject::GetCount

Gets the count of elements in the array.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetCount(
   out uint pdwElements
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetCount( 
   DWORD* pdwElements
);
```
---

## Parameters
`pdwElements`\
[out] Returns the count.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 This method sees all of the elements of an array object as a one-dimensional array, even if the array object is multi-dimensional. For example, given the array `myarray[3][2][6]`, this method would return 36 in the `pdwElements` parameter. Use the [GetElement](../../../extensibility/debugger/reference/idebugarrayobject-getelement.md) method to retrieve the individual elements one at a time.

## See also
- [IDebugArrayObject](../../../extensibility/debugger/reference/idebugarrayobject.md)
