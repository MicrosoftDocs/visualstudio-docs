---
description: "Gets an enumerator for all custom attributes attached to this field."
title: IDebugCustomAttributeQuery2::EnumCustomAttributes
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCustomAttributeQuery2::EnumCustomAttributes
helpviewer_keywords:
- IDebugCustomAttributeQuery2::EnumCustomAttributes
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugCustomAttributeQuery2::EnumCustomAttributes

Gets an enumerator for all custom attributes attached to this field.

## Syntax

### [C#](#tab/csharp)
```csharp
int EnumCustomAttributes(
   out IEnumDebugCustomAttributes ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnumCustomAttributes( 
   IEnumDebugCustomAttributes** ppEnum
);
```
---

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
