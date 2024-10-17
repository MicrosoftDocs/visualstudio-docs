---
description: Retrieves a flag that specifies whether the function contains asynchronous (structured) exception handling.
title: "IDiaSymbol::get_hasEHa"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_hasEHa method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_hasEHa

Retrieves a flag that specifies whether the function contains asynchronous (structured) exception handling.

## Syntax

```C++
HRESULT get_hasEHa(
   BOOL *pFlag
);
```

#### Parameters
 `pFlag`

[out] Returns `TRUE` if the function has any asynchronous exception handling; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Remarks
 It is possible to mix asynchronous or structured exception handling with C++-style exception handling, but it requires a specific compiler switch, /EHa, to enable it.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v8.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
