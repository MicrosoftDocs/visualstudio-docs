---
description: "Gets an enumerator of all elements of the array."
title: IDebugArrayObject::GetElements
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugArrayObject::GetElements
helpviewer_keywords:
- IDebugArrayObject::GetElements method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugArrayObject::GetElements

Gets an enumerator of all elements of the array.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetElements(
   out IEnumDebugObjects ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetElements( 
   IEnumDebugObjects** ppEnum
);
```
---

## Parameters
`ppEnum`\
[out] Returns an [IEnumDebugObjects](../../../extensibility/debugger/reference/ienumdebugobjects.md) object that allows enumerating over all elements.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 As an alternative, use the [GetCount](../../../extensibility/debugger/reference/idebugarrayobject-getcount.md) and [GetElement](../../../extensibility/debugger/reference/idebugarrayobject-getelement.md) methods to iterate through the elements.

## See also
- [IDebugArrayObject](../../../extensibility/debugger/reference/idebugarrayobject.md)
