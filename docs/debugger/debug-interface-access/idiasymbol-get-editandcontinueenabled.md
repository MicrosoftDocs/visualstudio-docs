---
description: Retrieves a flag indicating whether the module was compiled with the /Z7, /Zi, /ZI (Debug Information Format)) compiler switch.
title: "IDiaSymbol::get_editAndContinueEnabled"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_editAndContinueEnabled method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_editAndContinueEnabled

Retrieves a flag indicating whether the module was compiled with the [/Z7, /Zi, /ZI (Debug Information Format)](/cpp/build/reference/z7-zi-zi-debug-information-format) compiler switch.

## Syntax

```C++
HRESULT get_editAndContinueEnabled ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if edit-and-continue was enabled at compilation; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v7.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [/Z7, /Zi, /ZI (Debug Information Format)](/cpp/build/reference/z7-zi-zi-debug-information-format)
