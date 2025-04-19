---
description: "Retrieves a flag indicating whether this is a WinRT reference user-defined type (UDT)."
title: "IDiaSymbol::get_isRefUdt"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_isRefUdt method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_isRefUdt

Retrieves a flag indicating whether this is a WinRT reference user-defined type (UDT).

## Syntax

```C++
HRESULT get_isRefUdt ( 
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` if this symbol is a WinRT reference class/struct; otherwise, `FALSE`.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`IDiaSymbol::get_isInterfaceUdt`](../../debugger/debug-interface-access/idiasymbol-get-isinterfaceudt.md)
- [`IDiaSymbol::get_isValueUdt`](../../debugger/debug-interface-access/idiasymbol-get-isvalueudt.md)
