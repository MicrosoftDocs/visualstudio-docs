---
description: Retrieves a symbol by means of an index.
title: "IDiaEnumSymbols::Item"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSymbols::Item method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumSymbols::Item

Retrieves a symbol by means of an index.

## Syntax

```c++
HRESULT Item ( 
   DWORD        index,
   IDiaSymbol** symbol
);
```

#### Parameters

index

[in] Index of the [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object to be retrieved. The index is in the range 0 to `count`-1, where `count` is returned by the [IDiaEnumSymbols::get_Count](../../debugger/debug-interface-access/idiaenumsymbols-get-count.md) method.

symbol

[out] Returns an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object representing the desired symbol.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
