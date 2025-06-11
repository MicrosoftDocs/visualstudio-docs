---
description: "Gets an element of the array."
title: IDebugArrayObject::GetElement
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugArrayObject::GetElement
helpviewer_keywords:
- IDebugArrayObject::GetElement method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugArrayObject::GetElement

Gets an element of the array.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetElement(
   [In] uint dwIndex,
   out IDebugObject ppElement
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetElement( 
   DWORD          dwIndex,
   IDebugObject** ppElement
);
```
---

## Parameters
`dwIndex`\
[in] The element index.

`ppElement`\
[out] Returns an [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) interface that represents the element.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 This method sees all of the elements of an array object as a one-dimensional array, even if the array object is multi-dimensional. For example, given the array `myarray[3][2][6]` and a `dwIndex` parameter of 20, this method would return the element from `myarray[1][1][2]`, and a `dwIndex` parameter of 21 would return the element from `myarray[1][1][3]`. Use the [GetCount](../../../extensibility/debugger/reference/idebugarrayobject-getcount.md) method to determine the total number of elements in the array.

## See also
- [IDebugArrayObject](../../../extensibility/debugger/reference/idebugarrayobject.md)
