---
description: Retrieves a flag indicating whether this is an instance constructor of a class with virtual base.
title: "IDiaSymbol::get_isConstructorVirtualBase"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_isConstructorVirtualBase method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_isConstructorVirtualBase

Retrieves a flag indicating whether this is an instance constructor of a class with virtual base.

## Syntax

```C++
HRESULT get_isConstructorVirtualBase ( 
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` if This constructor has a hidden param to control initialization of virtual bases; otherwise, returns `FALSE`.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
