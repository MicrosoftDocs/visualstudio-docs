---
title: "IDebugCustomAttribute::GetAttributeTypeField | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugCustomAttribute::GetAttributeTypeField"
helpviewer_keywords:
  - "IDebugCustomAttribute::GetAttributeTypeField"
ms.assetid: d6ce26d5-42ba-44c1-8659-0516db5bc82d
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugCustomAttribute::GetAttributeTypeField
Gets the custom attribute class type.

## Syntax

```cpp
HRESULT GetAttributeTypeField( 
   IDebugClassField** ppCAType
);
```

```csharp
int GetAttributeTypeField(
   out IDebugClassField ppCAType
);
```

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