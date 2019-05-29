---
title: "IDebugMethodField::IsCustomAttributeDefined | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugMethodField::IsCustomAttributeDefined"
helpviewer_keywords:
  - "IDebugMethodField::IsCustomAttributeDefined method"
ms.assetid: 1b5d95a8-cc87-4acb-9e6a-3928f3632b7c
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugMethodField::IsCustomAttributeDefined
Determines whether a specific custom attribute has been defined.

## Syntax

```cpp
HRESULT IsCustomAttributeDefined( 
   LPCOLESTR pszCustomAttributeName
);
```

```csharp
int IsCustomAttributeDefined(
   [In] string pszCustomAttributeName
);
```

## Parameters
`pszCustomAttributeName`\
[in] A string containing the name of the custom attribute to find.

## Return Value
 Returns S_OK if the custom attribute is defined on this method, otherwise returns S_FALSE.

## See also
- [IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md)