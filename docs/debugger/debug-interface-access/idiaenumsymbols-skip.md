---
description: Skips a specified number of symbols in an enumeration sequence.
title: "IDiaEnumSymbols::Skip"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSymbols::Skip method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumSymbols::Skip

Skips a specified number of symbols in an enumeration sequence.

## Syntax

```c++
HRESULT Skip ( 
   ULONG celt
);
```

#### Parameters

celt

[in] The number of symbols in the enumeration sequence to skip.

## Return Value

If successful, returns `S_OK`; otherwise, returns `S_FALSE` if there are no more symbols to skip.

## See also

- [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md)
