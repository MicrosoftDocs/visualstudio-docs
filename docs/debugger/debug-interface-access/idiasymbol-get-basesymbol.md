---
title: "IDiaSymbol::get_baseSymbol | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
ms.assetid: cabb5a18-bda7-47e8-9e46-5f4718579fc9
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_baseSymbol
Retrieves the symbol from which the pointer is based.

## Syntax

```C++
HRESULT get_baseSymbol(
   IDiaSymbol** pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to the symbol from which the pointer is based.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [IDiaSymbol::get_baseSymbolId](../../debugger/debug-interface-access/idiasymbol-get-basesymbolid.md)