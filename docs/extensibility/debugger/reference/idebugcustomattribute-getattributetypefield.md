---
description: "Gets the custom attribute class type."
title: IDebugCustomAttribute::GetAttributeTypeField
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCustomAttribute::GetAttributeTypeField
helpviewer_keywords:
- IDebugCustomAttribute::GetAttributeTypeField
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugCustomAttribute::GetAttributeTypeField

Gets the custom attribute class type.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetAttributeTypeField(
   out IDebugClassField ppCAType
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetAttributeTypeField( 
   IDebugClassField** ppCAType
);
```
---

## Parameters
`ppCAType`\
[out] Returns the [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) object that represents the class of which the custom attribute is an instance.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 A custom attribute is always a class. This method provides access to an [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) object that describes that class.

## See also
- [IDebugCustomAttribute](../../../extensibility/debugger/reference/idebugcustomattribute.md)
- [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md)
