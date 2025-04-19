---
description: "Retrieves the ordinal of this export."
title: "IDiaSymbol::get_ordinal"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_ordinal method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_ordinal

Retrieves the ordinal of this export.

## Syntax

```C++
HRESULT get_ordinal ( 
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the ordinal of this export.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`EXPORTS`](/cpp/build/reference/exports)
