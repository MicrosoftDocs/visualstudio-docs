---
description: "Retrieves a flag indicating whether the module is a .netmodule (a Microsoft Intermediate Language (MSIL) module that contains only metadata and no native symbols)."
title: "IDiaSymbol::get_isMSILNetmodule"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_isMSILNetmodule method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_isMSILNetmodule

Retrieves a flag indicating whether the module is a .netmodule (a Microsoft Intermediate Language (MSIL) module that contains only metadata and no native symbols).

## Syntax

```C++
HRESULT get_isMSILNetmodule(
   BOOL *pFlag
);
```

#### Parameters
 `pFlag`

[out] Returns `TRUE` if the module is MSIL; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Remarks
 This property is available from the `SymTagCompilandDetails` symbol type (see [CompilandDetails](../../debugger/debug-interface-access/compilanddetails.md)).

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v8.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [CompilandDetails](../../debugger/debug-interface-access/compilanddetails.md)
