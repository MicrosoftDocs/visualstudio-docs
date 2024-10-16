---
description: "Retrieves the ID of the original (unmodified) type."
title: "IDiaSymbol::get_unmodifiedTypeId"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_unmodifiedTypeId

Retrieves the ID of the original (unmodified) type.

## Syntax

```C++
HRESULT get_unmodifiedTypeId(
   DWORD* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `DWORD` that holds the ID.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
