---
title: "IDebugPropertyField::GetPropertySetter | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugPropertyField::GetPropertySetter"
helpviewer_keywords:
  - "IDebugPropertyField::GetPropertySetter method"
ms.assetid: 744d76fd-2bcc-4917-a040-ce4cc714ef61
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugPropertyField::GetPropertySetter
Gets the method that sets the property.

## Syntax

```cpp
HRESULT GetPropertySetter( 
   IDebugMethodField** ppField
);
```

```csharp
int GetPropertySetter(
   out IDebugMethodField ppField
);
```

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