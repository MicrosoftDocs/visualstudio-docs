---
description: Retrieves a flag indicating whether this export is CONSTANT.
title: "IDiaSymbol::get_constantExport"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_constantExport method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_constantExport

Retrieves a flag indicating whether this export is `CONSTANT`.

## Syntax

```C++
HRESULT get_contantExport ( 
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` if the export symbol is marked as `CONSTANT`; otherwise, returns `FALSE`.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`EXPORTS`](/cpp/build/reference/exports)
