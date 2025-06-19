---
description: "Retrieves a flag that specifies whether the preprocessor directive for a safe buffer is used."
title: "IDiaSymbol::get_isSafeBuffers"
ms.date: "07/22/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_isSafeBuffers method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_isSafeBuffers

Retrieves a flag that specifies whether the preprocessor directive for a safe buffer is used. Use when the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) is set to `SymTagFunction`.

## Syntax

```C++
HRESULT get_isSafeBuffers( 
   BOOL* pRetVal)
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the pointer uses a preprocessor directive for a safe buffer; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks

## Requirements
 Header: Dia2.h

 Library: diaguids.lib

 DLL: msdia100.dll

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [`safebuffers`](/cpp/cpp/safebuffers)
- [`strict_gs_check` pragma](/cpp/preprocessor/strict-gs-check)
