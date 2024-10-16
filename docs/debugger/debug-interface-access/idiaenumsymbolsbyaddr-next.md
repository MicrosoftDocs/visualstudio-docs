---
description: Retrieves the next symbols in order by address.
title: "IDiaEnumSymbolsByAddr::Next"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSymbolsByAddr::Next method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumSymbolsByAddr::Next

Retrieves the next symbols in order by address.

## Syntax

```c++
HRESULT Next ( 
   ULONG        celt,
   IDiaSymbol** rgelt,
   ULONG*       pceltFetched
);
```

#### Parameters

celt

[in] The number of symbols in the enumerator to be retrieved.

rgelt

[out] An array that is to be filled in with the [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object that represent the desired symbols.

pceltFetched

[out] Returns the number of symbols in the fetched enumerator.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if there are no more symbols. Otherwise, returns an error code.

## Remarks

This method updates the enumerator position by the number of elements fetched.

## See also

- [IDiaEnumSymbolsByAddr](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
