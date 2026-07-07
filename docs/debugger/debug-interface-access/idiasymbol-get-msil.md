---
description: "Retrieves a flag that specifies whether the symbol refers to Microsoft Intermediate Language (MSIL) code."
title: "IDiaSymbol::get_msil"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_msil method"
author: nitinme
ms.author: nitinme

ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_msil

Retrieves a flag that specifies whether the symbol refers to Microsoft Intermediate Language (MSIL) code.

## Syntax

```C++
HRESULT get_msil ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the symbol refers to MSIL code; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
