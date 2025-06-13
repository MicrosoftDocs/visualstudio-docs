---
description: "This method returns the type of object to which this pointer object points."
title: IDebugPointerField::GetDereferencedField
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPointerField::GetDereferencedField
helpviewer_keywords:
- IDebugPointerField::GetDereferencedField method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPointerField::GetDereferencedField

This method returns the type of object to which this pointer object points.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetDereferencedField(
   out IDebugField ppField
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetDereferencedField(
   IDebugField** ppField
);
```
---

## Parameters
`ppField`\
[out] Returns an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) describing the type of target object.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 If, for example, the [IDebugPointerField](../../../extensibility/debugger/reference/idebugpointerfield.md) object points to an integer, the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) type returned by this method describes that integer type.

## See also
- [IDebugPointerField](../../../extensibility/debugger/reference/idebugpointerfield.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
