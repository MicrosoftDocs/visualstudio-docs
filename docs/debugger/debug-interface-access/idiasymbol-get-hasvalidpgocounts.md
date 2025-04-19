---
description: Retrieves a flag indicating whether this symbols has valid profile-guided optimizations (PGO) counts.
title: "IDiaSymbol::get_hasValidPGOCounts"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_hasValidPGOCounts method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_hasValidPGOCounts

Retrieves a flag indicating whether this symbols has valid profile-guided optimizations (PGO) counts.

## Syntax

```C++
HRESULT get_isget_hasValidPGOCountsPGO ( 
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` if this function has valid profile-guided optimization counts from a training scenario; otheriwse, `FALSE`.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [Profile-guided optimizations](/cpp/build/profile-guided-optimizations)
