---
description: "Retrieves the number of register indices."
title: "IDiaSymbol::get_numberOfRegisterIndices"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
author: nitinme
ms.author: nitinme

ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_numberOfRegisterIndices

Retrieves the number of register indices.

## Syntax

```C++
HRESULT get_numberOfRegisterIndices(
   DWORD* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `DWORD` that holds the number of register indices.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
