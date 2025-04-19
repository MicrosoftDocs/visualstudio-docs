---
description: Retrieves a flag indicating whether this function contains control flow checks.
title: "IDiaSymbol::get_get_hasControlFlowCheck"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_get_hasControlFlowCheck method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_get_hasControlFlowCheck

Retrieves a flag indicating whether this function contains control flow checks.

## Syntax

```C++
HRESULT get_get_hasControlFlowCheck ( 
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` if this function was compiled with `/guard:cf`; otherwase, returns `FALSE'.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`/guard` (Enable Control Flow Guard)](/cpp/build/reference/guard-enable-control-flow-guard)
