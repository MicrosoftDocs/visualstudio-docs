---
description: Positions the enumerator by performing a lookup by relative virtual address (RVA). Method of IDiaEnumSymbolsByAddr2.
title: "IDiaEnumSymbolsByAddr2::symbolByRVAEx"
ms.date: "7/2/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSymbolsByAddr2::symbolByRVAEx method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumSymbolsByAddr2::symbolByRVAEx

Positions the enumerator by performing a lookup by relative virtual address (RVA).

## Syntax

```C++
HRESULT symbolByRVAEx (
   BOOL         fPromoteBlockSym,
   DWORD        relativeVirtualAddress,
   IDiaSymbol** ppsymbol
);
```

#### Parameters

 `fPromoteBlockSym`

[in] Whether or not to enumerate SymTagBlock symbols or promote them to an outer/parent symbol (like SymTagFuncton or SymTagPublicSymbol). If `FALSE` returns unpromoted SymTagBlock. Otherwise behaves identically to [`IDiaEnumSymbolsByAddr::symbolByRVA`](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr-symbolbyrva.md)

 `relativeVirtualAddress`

[in] Address relative to start of image.

 `ppsymbol`

[out] Returns an [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md) object representing the symbol found.

## Return Value

 If successful, returns `S_OK`. Returns `S_FALSE` if the symbol could not be found. Otherwise, returns an error code.

## See also

- [`IDiaEnumSymbolsByAddr::symbolByRVA`](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr-symbolbyrva.md)
- [`IDiaEnumSymbolsByAddr2`](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr2.md)
- [`IDiaEnumSymbolsByAddr2::symbolByVAEx`](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr2-symbolbyvaex.md)
- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
