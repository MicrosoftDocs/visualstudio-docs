---
description: "Retrieves a flag indicating whether the function is optimized for speed."
title: "IDiaSymbol::get_isOptimizedForSpeed"
ms.date: "07/26/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_isOptimizedForSpeed

Retrieves a flag indicating whether the function is optimized for speed.

## Syntax

```C++
HRESULT get_isOptimizedForSpeed(
   BOOL* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `BOOL` that specifies whether the function is optimized for speed. `TRUE` would indicate that the function was compiled with `/Ot` telling the compiler to favor fast code (speed).

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`/Os`, `/Ot` (Favor Small Code, Favor Fast Code)](/cpp/build/reference/os-ot-favor-small-code-favor-fast-code)
