---
description: "Retrieves a flag indicating whether profile-guided optimizations (PGO) were performed for this function."
title: "IDiaSymbol::get_isPGO"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_isPGO method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_isPGO

Retrieves a flag indicating whether profile-guided optimizations (PGO) were performed for this function.

## Syntax

```C++
HRESULT get_isPGO ( 
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` if profile-guided optimizations were performed for this function; otherwise, `FALSE`.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [Profile-guided optimizations](/cpp/build/profile-guided-optimizations)
