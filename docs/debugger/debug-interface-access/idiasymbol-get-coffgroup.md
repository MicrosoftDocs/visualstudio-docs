---
description: Retrieves the COFF group symbol this symbol comes from.
title: "IDiaSymbol::get_coffGroup"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_coffGroup method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_coffGroup

Retrieves the COFF group symbol this symbol comes from.

## Syntax

```C++
HRESULT get_coffGroup ( 
   IDiaSymbol** pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the `IDiaSymbol*` that represents the COFF group that this symbols comes from.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
