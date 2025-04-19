---
description: "Retrieves a flag indicating whether this is a WinRT pointer type."
title: "IDiaSymbol::get_isWinRTPointer"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_isWinRTPointer method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_isWinRTPointer

Retrieves a flag indicating whether this is a WinRT pointer type.

## Syntax

```C++
HRESULT get_isWinRTPointer ( 
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` if the symbol is a WinRT pointer; otherwise, `FALSE`.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
