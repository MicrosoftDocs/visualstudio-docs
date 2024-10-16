---
description: Positions the enumerator by performing a lookup by relative virtual address (RVA).
title: "IDiaEnumSymbolsByAddr::symbolByRVA"
ms.date: "07/22/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSymbolsByAddr::symbolByRVA method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumSymbolsByAddr::symbolByRVA

Positions the enumerator by performing a lookup by relative virtual address (RVA).

## Syntax

```c++
HRESULT symbolByRVA (
   DWORD        relativeVirtualAddress,
   IDiaSymbol** ppsymbol
);
```

#### Parameters

`relativeVirtualAddress`

[in] Address relative to start of image.

`ppsymbol`

[out] Returns an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object representing the symbol found.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if the symbol could not be found. Otherwise, returns an error code.

## See also

- [`IDiaEnumSymbolsByAddr`](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr.md)
- [`IDiaEnumSymbolsByAddr::symbolByVA`](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr-symbolbyva.md)
- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
