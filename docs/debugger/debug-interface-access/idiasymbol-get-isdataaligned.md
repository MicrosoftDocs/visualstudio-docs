---
description: "Retrieves a flag that specifies whether the user-defined type (UDT) has been aligned to some specific memory boundary."
title: "IDiaSymbol::get_isDataAligned"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_isDataAligned method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_isDataAligned

Retrieves a flag that specifies whether the user-defined type (UDT) has been aligned to some specific memory boundary.

## Syntax

```C++
HRESULT get_isDataAligned(
   BOOL *pFlag
);
```

#### Parameters
 `pFlag`

[out] Returns `TRUE` if the UDT has been aligned to some memory boundary; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Remarks
 This property is generally set when the executable is compiled with nondefault data alignment. For example, the Microsoft C++ compiler can change the data alignment with the command-line option, /Zp<em>#</em>, where *#* is a byte value.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v8.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
