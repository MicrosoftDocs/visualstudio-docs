---
title: "IDiaSymbol::get_baseSymbolId | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
ms.assetid: cd504d2b-194f-4106-8de5-2de827a79cbd
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_baseSymbolId
Retrieves the symbol ID from which the pointer is based.

## Syntax

```C++
HRESULT get_baseSymbolId(
   DWORD *pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `DWORD` that holds the symbol ID from which the pointer is based.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [IDiaSymbol::get_baseSymbol](../../debugger/debug-interface-access/idiasymbol-get-basesymbol.md)