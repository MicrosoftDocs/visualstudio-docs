---
description: "Retrieves the symbol from which the pointer is based."
title: "IDiaSymbol::get_baseSymbol"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.subservice: vs-ide-debug
---
# IDiaSymbol::get_baseSymbol

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
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
