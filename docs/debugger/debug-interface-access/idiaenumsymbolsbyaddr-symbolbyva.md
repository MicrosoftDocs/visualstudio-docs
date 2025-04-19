---
description: Positions the enumerator by performing a lookup by virtual address (VA).
title: "IDiaEnumSymbolsByAddr::symbolByVA"
ms.date: "07/22/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSymbolsByAddr::symbolByVA method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumSymbolsByAddr::symbolByVA

Positions the enumerator by performing a lookup by virtual address (VA).

## Syntax

```c++
HRESULT symbolByVA (
   ULONGLONG    virtualAddress,
   IDiaSymbol** ppsymbol
);
```

#### Parameters

`virtualAddress`

[in] Virtual address.

`ppsymbol`

[out] Returns an [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md) object representing the symbol found.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if the symbol could not be found. Otherwise, returns an error code.

## See also

- [`IDiaEnumSymbolsByAddr`](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr.md)
- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
