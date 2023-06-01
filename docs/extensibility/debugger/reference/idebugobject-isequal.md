---
description: "Compares an object with this object."
title: IDebugObject::IsEqual | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugObject::IsEqual
helpviewer_keywords:
- IDebugObject::IsEqual method
ms.assetid: 4b76e663-ef2e-41ff-9be1-bf26d666a34a
author: maiak
ms.author: maiak
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugObject::IsEqual

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Compares an object with this object.

## Syntax

### [C#](#tab/csharp)
```csharp
int IsEqual(
   IDebugObject pObject,
   out int      pfIsEqual
);
```
### [C++](#tab/cpp)
```cpp
HRESULT IsEqual( 
   IDebugObject* pObject,
   BOOL*         pfIsEqual
);
```
---

## Parameters
`pObject`\
[in] An [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) object representing the object to compare to.

`pfIsEqual`\
[out] Returns non-zero (`TRUE`) if the values of the objects are equal; otherwise, returns zero (`FALSE`).

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 Typically, this method can compare the addresses of the values represented by the `pObject` parameter and this [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) object; if the addresses are equal, then the objects can be considered equal.

## See also
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)
