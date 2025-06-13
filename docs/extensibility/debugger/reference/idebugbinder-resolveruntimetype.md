---
description: "This method determines the run-time type of an object."
title: IDebugBinder::ResolveRuntimeType
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBinder::ResolveRuntimeType
helpviewer_keywords:
- IDebugBinder::ResolveRuntimeType method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBinder::ResolveRuntimeType

This method determines the run-time type of an object.

## Syntax

### [C#](#tab/csharp)
```csharp
int ResolveRuntimeType(
   IDebugObject     pObject,
   out IDebugField  ppResolved
);
```
### [C++](#tab/cpp)
```cpp
HRESULT ResolveRuntimeType( 
   IDebugObject* pObject,
   IDebugField** ppResolved
);
```
---

## Parameters
`pObject`\
[in] The [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) to be resolved.

`ppResolved`\
[out] Returns the type of the object as an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md).

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The run-time type of an object is not always known at compile time. For example, using polymorphism, an argument can be passed to a function as its base class, such as a button class. The actual argument might be a derived class, such as a radio button class.

## See also
- [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md)
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
