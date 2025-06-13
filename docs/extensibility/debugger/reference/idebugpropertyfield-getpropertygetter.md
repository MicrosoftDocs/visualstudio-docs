---
description: "Gets the method that gets the property."
title: IDebugPropertyField::GetPropertyGetter
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPropertyField::GetPropertyGetter
helpviewer_keywords:
- IDebugPropertyField::GetPropertyGetter method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPropertyField::GetPropertyGetter

Gets the method that gets the property.

## Syntax

```cpp
HRESULT GetPropertyGetter( 
   IDebugMethodField** ppField
);
```

```cpp
int GetPropertyGetter(
   out IDebugMethodField ppField
);
```

## Parameters
`ppField`\
[out] Returns an [IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md) object representing the method that gets the property.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 To get the method that sets the property, [GetPropertySetter](../../../extensibility/debugger/reference/idebugpropertyfield-getpropertysetter.md) call the method.

## See also
- [IDebugPropertyField](../../../extensibility/debugger/reference/idebugpropertyfield.md)
- [GetPropertySetter](../../../extensibility/debugger/reference/idebugpropertyfield-getpropertysetter.md)
- [IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md)
