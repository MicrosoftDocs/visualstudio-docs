---
description: Retrieves the next symbols in order by address. Method of IDiaEnumSymbolsByAddr2.
title: "IDiaEnumSymbolsByAddr2::NextEx"
ms.date: "7/2/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSymbolsByAddr2::NextEx method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumSymbolsByAddr2::NextEx

Retrieves the next symbols in order by address.

## Syntax

```C++
HRESULT NextEx (
   BOOL         fPromoteBlockSym,
   ULONG        celt,
   IDiaSymbol** rgelt,
   ULONG*       pceltFetched
);
```

#### Parameters

 `fPromoteBlockSym`

[in] Whether or not to enumerate SymTagBlock symbols or promote them to an outer/parent symbol (like SymTagFuncton or SymTagPublicSymbol). If `FALSE` returns unpromoted SymTagBlock. Otherwise behaves identically to [`IDiaEnumSymbolsByAddr::Next`](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr-next.md)

[in]

 `celt`

[in] The number of symbols in the enumerator to be retrieved.

 `rgelt`

[out] An array that is to be filled in with the [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md) object that represent the desired symbols.

 `pceltFetched`

[out] Returns the number of symbols in the fetched enumerator.

## Return Value

 If successful, returns `S_OK`. Returns `S_FALSE` if there are no more symbols. Otherwise, returns an error code.

## Remarks

 This method updates the enumerator position by the number of elements fetched.

## See also

- [`IDiaEnumSymbolsByAddr::Next`](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr-next.md)
- [`IDiaEnumSymbolsByAddr2`](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr2.md)
- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
