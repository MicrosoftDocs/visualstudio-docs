---
description: "Creates an enumerator for static local variables of the method."
title: IDebugMethodField::EnumStaticLocals
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugMethodField::EnumStaticLocals
helpviewer_keywords:
- IDebugMethodField::EnumStaticLocals method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugMethodField::EnumStaticLocals

Creates an enumerator for static local variables of the method.

## Syntax

### [C#](#tab/csharp)
```csharp
int EnumStaticLocals(
   out IEnumDebugFields ppLocals
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnumStaticLocals( 
   IEnumDebugFields** ppLocals
);
```
---

## Parameters
`ppLocals`\
[out] Returns an [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md) object representing the list of static locals. Returns a null value if there are no static locals.

## Return Value
 If successful, returns S_OK or returns S_FALSE if there are no static locals. Otherwise, returns an error code.

## Remarks
 Each element is an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object representing different types of static locals. Call the [GetKind](../../../extensibility/debugger/reference/idebugfield-getkind.md) method on each object to determine exactly what kind of static local the object represents.

## See also
- [IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md)
- [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
