---
description: Retrieves all children of a specified parent identifier that match the name and symbol type, including optimized locals.
title: "IDiaSession::findChildrenEx"
ms.date: "7/2/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::findChildrenEx method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSession::findChildrenEx

Retrieves all children of a specified parent identifier that match the name and symbol type, including optimized locals.

## Syntax

```C++
HRESULT findChildrenEx (
   IDiaSymbol*       parent,
   SymTagEnum        symtag,
   LPCOLESTR         name,
   DWORD             compareFlags,
   IDiaEnumSymbols** ppResult
);
```

#### Parameters

 `parent`

[in] An [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md) object representing the parent. If this parent symbol is a function, module, or block, then its lexical children are returned in `ppResult`. If the parent symbol is a type, then its class children are returned. If this parameter is `NULL`, then `symtag` must be set to `SymTagExe` or `SymTagNull`, which returns the global scope (.exe file).

 `symtag`

[in] Specifies the symbol tag of the children to be retrieved. Values are taken from the [`SymTagEnum` Enumeration](../../debugger/debug-interface-access/symtagenum.md) enumeration. Set to `SymTagNull` to retrieve all children.

 `name`

[in] Specifies the name of the children to be retrieved. Set to `NULL` for all children to be retrieved.

 `compareFlags`

[in] Specifies the comparison options applied to name matching. Values from the [`NameSearchOptions` Enumeration](../../debugger/debug-interface-access/namesearchoptions.md) enumeration can be used alone or in combination.

 `ppResult`

[out] Returns an [`IDiaEnumSymbols`](../../debugger/debug-interface-access/idiaenumsymbols.md) object that contains the list of child symbols retrieved.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## Example

 The following example shows how to find local variables of function `pFunc` that match name `szVarName`.

```C++
IDiaEnumSymbols* pEnum;
pSession->findChildrenEx( pFunc, SymTagData, szVarName, nsCaseSensitive, &pEnum );
```

## See also

- [Overview](../../debugger/debug-interface-access/overview-debug-interface-access-sdk.md)
- [`IDiaEnumSymbols`](../../debugger/debug-interface-access/idiaenumsymbols.md)
- [`IDiaSession`](../../debugger/debug-interface-access/idiasession.md)
- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`NameSearchOptions` Enumeration](../../debugger/debug-interface-access/namesearchoptions.md)
- [`SymTagEnum` Enumeration](../../debugger/debug-interface-access/symtagenum.md)
