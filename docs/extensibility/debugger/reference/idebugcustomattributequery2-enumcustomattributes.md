---
description: "Gets an enumerator for all custom attributes attached to this field."
title: IDebugCustomAttributeQuery2::EnumCustomAttributes | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCustomAttributeQuery2::EnumCustomAttributes
helpviewer_keywords:
- IDebugCustomAttributeQuery2::EnumCustomAttributes
ms.assetid: 94bfce74-aa3d-45f0-8e04-5715faf85217
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugCustomAttributeQuery2::EnumCustomAttributes
Gets an enumerator for all custom attributes attached to this field.

## Syntax

```cpp
HRESULT EnumCustomAttributes( 
   IEnumDebugCustomAttributes** ppEnum
);
```

```csharp
int EnumCustomAttributes(
   out IEnumDebugCustomAttributes ppEnum
);
```

## Parameters
`ppEnum`\
[out] Returns an [IEnumDebugCustomAttributes](../../../extensibility/debugger/reference/ienumdebugcustomattributes.md) object representing the list of custom attributes; otherwise, returns a null value if there are no custom attributes.

## Return Value
 If successful, returns S_OK or S_FALSE if there are no custom attributes on this field. Otherwise, returns an error code;

## Remarks
 A field can have multiple custom attributes.

## See also
- [IDebugCustomAttributeQuery2](../../../extensibility/debugger/reference/idebugcustomattributequery2.md)
- [IEnumDebugCustomAttributes](../../../extensibility/debugger/reference/ienumdebugcustomattributes.md)
