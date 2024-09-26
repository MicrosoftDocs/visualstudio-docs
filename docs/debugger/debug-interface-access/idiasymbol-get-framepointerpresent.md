---
description: Retrieves a flag that specifies whether the frame pointer is present.
title: "IDiaSymbol::get_framePointerPresent"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_framePointerPresent method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_framePointerPresent

Retrieves a flag that specifies whether the frame pointer is present. Use when the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) is set to `SymTagFunction`.

## Syntax

```C++
HRESULT get_framePointerPresent( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out]] Returns `TRUE` if the frame pointer is present; otherwise, returns `FALSE`.

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
