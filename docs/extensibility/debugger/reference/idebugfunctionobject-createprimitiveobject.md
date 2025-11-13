---
description: "Creates a primitive data object, such as a simple integer."
title: IDebugFunctionObject::CreatePrimitiveObject
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugFunctionObject::CreatePrimitiveObject
helpviewer_keywords:
- IDebugFunctionObject::CreatePrimitiveObject method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugFunctionObject::CreatePrimitiveObject

Creates a primitive data object, such as a simple integer.

## Syntax

### [C#](#tab/csharp)
```csharp
int CreatePrimitiveObject(
   enum_OBJECT_TYPE ot,
   out IDebugObject ppObject
);
```
### [C++](#tab/cpp)
```cpp
HRESULT CreatePrimitiveObject( 
   OBJECT_TYPE    ot,
   IDebugObject** ppObject
);
```
---

## Parameters
`ot`\
[in] A value from the [OBJECT_TYPE](../../../extensibility/debugger/reference/object-type.md) enumeration representing the type of primitive to create.

`ppObject`\
[out] Returns an [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) representing the newly created object.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 Call this method to create an object that represents a primitive object that is a parameter to the function which is represented by the [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md) interface. For example, if the expression string is "myString(5)", this method would be used to create an object representing the integer 5.

## See also
- [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md)
