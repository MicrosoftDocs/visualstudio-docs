---
description: "Creates an enumerator for the constructors for this class."
title: IDebugClassField::EnumConstructors
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugClassField::EnumConstructors
helpviewer_keywords:
- IDebugClassField::EnumConstructors method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugClassField::EnumConstructors

Creates an enumerator for the constructors for this class.

## Syntax

### [C#](#tab/csharp)
```csharp
int EnumConstructors(
   CONSTRUCTOR_ENUM     cMatch,
   out IEnumDebugFields ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnumConstructors( 
   CONSTRUCTOR_ENUM   cMatch,
   IEnumDebugFields** ppEnum
);
```
---

## Parameters
`cMatch`\
[in] A value from the [CONSTRUCTOR_ENUM](../../../extensibility/debugger/reference/constructor-enum.md) enumeration that specifies the type of constructors to enumeration.

`ppEnum`\
[out] Returns an [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md) object representing the list of constructors. Returns a null value if there are no constructors.

## Return Value
 If successful, returns S_OK or returns S_FALSE if there are no constructors. Otherwise, returns an error code.

## Remarks
 Each element of the enumeration is an [IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md) object describing a constructor method.

 The list of constructors typically does not include the default constructors supplied by a compiler.

## See also
- [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md)
- [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md)
- [IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md)
- [CONSTRUCTOR_ENUM](../../../extensibility/debugger/reference/constructor-enum.md)
