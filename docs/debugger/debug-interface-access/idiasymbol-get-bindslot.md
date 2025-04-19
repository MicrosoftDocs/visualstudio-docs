---
description: Retrieves the lower bound in binding space.
title: "IDiaSymbol::get_bindSlot"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_bindSlot method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_bindSlot

Retrieves the lower bound in binding space.

## Syntax

```C++
HRESULT get_bindSlot (
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the lower bound in binding space.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
