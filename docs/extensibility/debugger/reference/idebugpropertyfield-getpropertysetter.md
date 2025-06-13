---
description: "Gets the method that sets the property."
title: IDebugPropertyField::GetPropertySetter
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPropertyField::GetPropertySetter
helpviewer_keywords:
- IDebugPropertyField::GetPropertySetter method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPropertyField::GetPropertySetter

Gets the method that sets the property.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetPropertySetter(
   out IDebugMethodField ppField
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetPropertySetter( 
   IDebugMethodField** ppField
);
```
---

## Parameters
`ppField`\
[out] Returns an [IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md) object representing the method that sets the property.

## Return Value
 If successful, returns S_OK; otherwise returns an error code.

## Remarks
 To get the method that gets the property, call the [GetPropertyGetter](../../../extensibility/debugger/reference/idebugpropertyfield-getpropertygetter.md) method.

## See also
- [IDebugPropertyField](../../../extensibility/debugger/reference/idebugpropertyfield.md)
- [IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md)
- [GetPropertyGetter](../../../extensibility/debugger/reference/idebugpropertyfield-getpropertygetter.md)
