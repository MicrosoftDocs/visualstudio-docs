---
description: Retrieves an enumerator for all SymTagHeapAllocationSite symbols.
title: "IDiaSession::getHeapAllocationSites"
ms.date: "07/05/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::getHeapAllocationSites method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSession::getHeapAllocationSites

Retrieves an enumerator for all `SymTagHeapAllocationSite` symbols.

## Syntax

```C++
HRESULT getHeapAllocationSites ( 
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
