---
description: Retrieves an enumerator for all exported symbols.
title: "IDiaSession::getExports"
ms.date: "07/05/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::getExports method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSession::getExports

Retrieves an enumerator for all exported symbols, symbols with `SymTagExport`, from a `.dll`.

## Syntax

```C++
HRESULT getExports ( 
   IDiaEnumSymbols** ppResult
);
```

#### Parameters

 `ppResult`

[out] Returns an [`IDiaEnumSymbols`](../../debugger/debug-interface-access/idiaenumsymbols.md) object that contains the list of symbols retrieved.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaEnumSymbols`](../../debugger/debug-interface-access/idiaenumsymbols.md)
- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`SymTagEnum` Enumeration](../../debugger/debug-interface-access/symtagenum.md)
