---
description: "Retrieves a flag indicating whether this function was compiled with strict_gs_check pragma enabled"
title: "IDiaSymbol::get_strictGSCheck"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_strictGSCheck method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_strictGSCheck

Retrieves a flag indicating whether this function was compiled with [`strict_gs_check` pragma](/cpp/preprocessor/strict-gs-check) enabled.

## Syntax

```C++
HRESULT get_strictGSCheck ( 
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` if the function was compiled with [`strict_gs_check` pragma](/cpp/preprocessor/strict-gs-check) enabled; otherwise, `FALSE`.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`strict_gs_check` pragma](/cpp/preprocessor/strict-gs-check)