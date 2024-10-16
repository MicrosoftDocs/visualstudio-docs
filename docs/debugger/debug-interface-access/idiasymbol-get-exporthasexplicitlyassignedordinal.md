---
description: Retrieves a flag indicating whether this export has an explicitly assigned ordinal.
title: "IDiaSymbol::get_exportHasExplicitlyAssignedOrdinal"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_exportHasExplicitlyAssignedOrdinal method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_exportHasExplicitlyAssignedOrdinal

Retrieves a flag indicating whether this export has an explicitly assigned ordinal.

## Syntax

```C++
HRESULT get_exportHasExplicitlyAssignedOrdinal(
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` if the export symbol is marked has an explicitly assigned ordinal; otherwise, returns `FALSE`. See remarks.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Remarks

All exports have an ordinal. Use this method to determine if the ordinal is implicitly defined by the linker, or if it was explicitly defined by the user using the `@ordinal` syntax.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`EXPORTS`](/cpp/build/reference/exports)
