---
description: "Determines whether a custom attribute exists by name."
title: IDebugCustomAttributeQuery2::IsCustomAttributeDefined
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCustomAttributeQuery2::IsCustomAttributeDefined
helpviewer_keywords:
- IDebugCustomAttributeQuery2::IsCustomAttributeDefined
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugCustomAttributeQuery2::IsCustomAttributeDefined

Determines whether a custom attribute exists by name.

## Syntax

### [C#](#tab/csharp)
```csharp
int IsCustomAttributeDefined(
   [In] string pszCustomAttributeName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT IsCustomAttributeDefined( 
   LPCOLESTR pszCustomAttributeName
);
```
---

## Parameters
`pszCustomAttributeName`\
[in] A string containing the name of the custom attribute to find.

## Return Value
 Returns S_OK if the custom attribute is defined on this field, otherwise returns S_FALSE.

## Remarks
 To obtain the attribute bytes associated with the custom attribute, call the [GetCustomAttributeByName](../../../extensibility/debugger/reference/idebugcustomattributequery2-getcustomattributebyname.md) method.

## See also
- [IDebugCustomAttributeQuery2](../../../extensibility/debugger/reference/idebugcustomattributequery2.md)
