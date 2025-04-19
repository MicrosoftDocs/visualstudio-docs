---
description: Retrieves the binding register index.
title: "IDiaSymbol::get_binID"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_bindID method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_bindID

Retrieves the binding register index.

## Syntax

```C++
HRESULT get_backEndQFE ( 
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the binding register index.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also
- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
