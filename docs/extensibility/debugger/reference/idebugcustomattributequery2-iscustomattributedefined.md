---
description: "Determines whether a custom attribute exists by name."
title: IDebugCustomAttributeQuery2::IsCustomAttributeDefined | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCustomAttributeQuery2::IsCustomAttributeDefined
helpviewer_keywords:
- IDebugCustomAttributeQuery2::IsCustomAttributeDefined
ms.assetid: 5c07cc52-6d2d-42df-9d76-9f1f769641db
author: maiak
ms.author: maiak
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugCustomAttributeQuery2::IsCustomAttributeDefined

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
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
