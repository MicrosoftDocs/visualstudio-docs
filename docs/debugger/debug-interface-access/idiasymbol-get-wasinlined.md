---
description: "Retrieves a flag indicating whether this function symbol was inlined into another function."
title: "IDiaSymbol::get_wasInlined"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_wasInlined method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_wasInlined

Retrieves a flag indicating whether this function symbol was inlined into another function.

## Syntax

```C++
HRESULT get_wasInlined ( 
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` if the function was inlined; otherwise, returns `FALSE`.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
