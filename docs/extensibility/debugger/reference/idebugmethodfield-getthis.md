---
description: "Gets the this (Me in Visual Basic) pointer of the object containing the method."
title: IDebugMethodField::GetThis
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugMethodField::GetThis
helpviewer_keywords:
- IDebugMethodField::GetThis method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugMethodField::GetThis

Gets the `this` (`Me` in Visual Basic) pointer of the object containing the method.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetThis(
   out IDebugClassField ppClass
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetThis( 
   IDebugClassField** ppClass
);
```
---

## Parameters
`ppClass`\
[out] Returns an [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) object representing the "this" pointer.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 In object-oriented languages, there is typically an implied pointer to the current instantiation of a class. This is known as `this` in C#/C++ and as `Me` in Visual Basic.

## See also
- [IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md)
- [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md)
