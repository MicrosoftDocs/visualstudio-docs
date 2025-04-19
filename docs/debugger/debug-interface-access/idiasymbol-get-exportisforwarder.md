---
description: Retrieves a flag indicating whether this export is a forwarder.
title: "IDiaSymbol::get_exportIsForwarder"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_exportIsForwarder method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_exportIsForwarder

Retrieves a flag indicating whether this export is a forwarder.

## Syntax

```C++
HRESULT get_exportIsForwarder ( 
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` if the export symbol is forwarded to another export in another module; otherwise, returns `FALSE`.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`EXPORTS`](/cpp/build/reference/exports)
