---
description: Positions the enumerator by performing a lookup by virtual address (VA). Method of IDiaEnumSymbolsByAddr2.
title: "IDiaEnumSymbolsByAddr2::symbolByVAEx"
ms.date: "7/2/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSymbolsByAddr2::symbolByVAEx method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumSymbolsByAddr2::symbolByVAEx

Positions the enumerator by performing a lookup by virtual address (VA).

## Syntax

```C++
HRESULT symbolByVA (
   BOOL         fPromoteBlockSym,
   ULONGLONG    virtualAddress,
   IDiaSymbol** ppsymbol
);
```

#### Parameters

 `fPromoteBlockSym`

[in] Whether or not to enumerate SymTagBlock symbols or promote them to an outer/parent symbol (like SymTagFuncton or SymTagPublicSymbol). If `FALSE` returns unpromoted SymTagBlock. Otherwise behaves identically to [`IDiaEnumSymbolsByAddr::symbolByVA`](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr-symbolbyva.md)

 `virtualAddress`

[in] Virtual address.

 `ppsymbol`

[out] Returns an [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md) object representing the symbol found.

## Return Value

 If successful, returns `S_OK`. Returns `S_FALSE` if the symbol could not be found. Otherwise, returns an error code.

## See also

- [`IDiaEnumSymbolsByAddr::symbolByVA`](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr-symbolbyva.md)
- [`IDiaEnumSymbolsByAddr2`](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr2.md)
- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
