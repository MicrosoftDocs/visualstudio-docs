---
description: "Retrieves the sub type."
title: "IDiaSymbol::get_subType"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_subType

Retrieves the sub type.

## Syntax

```C++
HRESULT get_subType(
   IDiaSymbol** pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to the sub type.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
