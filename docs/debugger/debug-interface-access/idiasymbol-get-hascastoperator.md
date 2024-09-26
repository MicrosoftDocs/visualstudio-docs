---
description: Retrieves a flag that specifies whether the user-defined data type has any cast operators defined.
title: "IDiaSymbol::get_hasCastOperator"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_hasCastOperator method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_hasCastOperator

Retrieves a flag that specifies whether the user-defined data type has any cast operators defined.

## Syntax

```C++
HRESULT get_hasCastOperator ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns a `TRUE` if the user-defined data type has any cast operators defined; otherwise, returns `FALSE`.

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
