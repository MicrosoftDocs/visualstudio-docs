---
description: "Retrieves a flag that specifies whether the function or label is never reached."
title: "IDiaSymbol::get_notReached"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_notReached method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_notReached

Retrieves a flag that specifies whether the function or label is never reached.

## Syntax

```C++
HRESULT get_notReached(
   BOOL *pFlag
);
```

#### Parameters
 pFlag

[out] Returns `TRUE` if the function or label is never reached; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v8.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
