---
description: "Deprecated function."
title: "IDiaSymbol::get_unused"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_unused method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_unused

Deprecated function.

## Syntax

```C++
HRESULT get_unused ( 
   BSTR* pReserved
);
```

#### Parameters

 `pReserved`

[out] Unused

## Return Value

 Always returns `E_NOTIMPL`;

## Remarks

 This method is deprecated. It should not be called, and always fails. It exists soleyl to maintain compatibility with vtable ordering as expected by older clients.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
