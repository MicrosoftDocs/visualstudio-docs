---
description: "This method gets the class field type representing a fully qualified class name."
title: IDebugSymbolProvider::GetClassTypeByName | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugSymbolProvider::GetClassTypeByName
helpviewer_keywords:
- IDebugSymbolProvider::GetClassTypeByName method
ms.assetid: 2c748909-51dc-49b7-b193-19f96fca1138
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugSymbolProvider::GetClassTypeByName
This method gets the class field type representing a fully qualified class name.

## Syntax

```cpp
HRESULT GetClassTypeByName( 
   LPCOLESTR          pszClassName,
   NAME_MATCH         nameMatch,
   IDebugClassField** ppField
);
```

```csharp
int GetClassTypeByName(
   string               pszClassName,
   NAME_MATCH           nameMatch,
   out IDebugClassField ppField
);
```

## Parameters
`pszClassName`\
[in] The class name.

`nameMatch`\
[in] Selects the type of match, for example, case-sensitive. A value from the [NAME_MATCH](../../../extensibility/debugger/reference/name-match.md) enumeration.

`ppField`\
[out] Returns the class type as represented by the [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) interface.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md)
- [NAME_MATCH](../../../extensibility/debugger/reference/name-match.md)
- [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md)
