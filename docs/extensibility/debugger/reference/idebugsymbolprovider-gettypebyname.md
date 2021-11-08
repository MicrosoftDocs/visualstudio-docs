---
description: "This method maps a symbol name to a symbol type."
title: IDebugSymbolProvider::GetTypeByName | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugSymbolProvider::GetTypeByName
helpviewer_keywords:
- IDebugSymbolProvider::GetTypeByName method
ms.assetid: b9d88d3b-8b75-484a-b9cc-dc8c0fbb4bc8
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
# IDebugSymbolProvider::GetTypeByName
This method maps a symbol name to a symbol type.

## Syntax

```cpp
HRESULT GetTypeByName( 
   LPCOLESTR     pszClassName,
   NAME_MATCH    nameMatch,
   IDebugField** ppField
);
```

```csharp
int GetTypeByName(
   string          pszClassName,
   NAME_MATCH      nameMatch,
   out IDebugField ppField
);
```

## Parameters
`pszClassName`\
[in] The symbol name.

`nameMatch`\
[in] Selects the type of match, for example, case-sensitive. A value from the [NAME_MATCH](../../../extensibility/debugger/reference/name-match.md) enumeration.

`ppField`\
[out] Returns the symbol type as an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is a generic version of [GetClassTypeByName](../../../extensibility/debugger/reference/idebugsymbolprovider-getclasstypebyname.md).

## See also
- [IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [NAME_MATCH](../../../extensibility/debugger/reference/name-match.md)
- [GetClassTypeByName](../../../extensibility/debugger/reference/idebugsymbolprovider-getclasstypebyname.md)
