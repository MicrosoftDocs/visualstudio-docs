---
description: Retrieves the binding space.
title: "IDiaSymbol::get_bindSpace"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_bindSpace method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_bindSpace

Retrives the binding space.

## Syntax

```C++
HRESULT get_bindSpace (
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the binding space.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
