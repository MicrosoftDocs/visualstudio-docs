---
description: "Retrieves a flag indicating whether this is a WinRT value user-defined type (UDT)."
title: "IDiaSymbol::get_isValueUdt"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_isValueUdt method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_isValueUdt

Retrieves a flag indicating whether this is a WinRT value user-defined type (UDT).

## Syntax

```C++
HRESULT get_isValueUdt ( 
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` if this symbol is a WinRT value class/struct; otherwise, `FALSE`.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`IDiaSymbol::get_isInterfaceUdt`](../../debugger/debug-interface-access/idiasymbol-get-isinterfaceudt.md)
- [`IDiaSymbol::get_isRefUdt`](../../debugger/debug-interface-access/idiasymbol-get-isrefudt.md)
