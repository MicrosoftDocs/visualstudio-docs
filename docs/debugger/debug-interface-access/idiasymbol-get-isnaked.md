---
description: "Retrieves a flag that specifies whether the function has the naked) attribute (that is, the function has no prolog or epilog code added by the compiler)."
title: "IDiaSymbol::get_isNaked"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_isNaked method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_isNaked

Retrieves a flag that specifies whether the function has the [naked](/cpp/cpp/naked-cpp) attribute (that is, the function has no prolog or epilog code added by the compiler).

## Syntax

```C++
HRESULT get_isNaked(
   BOOL *pFlag
);
```

#### Parameters
 `pFlag`

[out] Returns `TRUE` if the function has the `naked` attribute; otherwise, returns `FALSE`.

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
- [Naked Function Calls](/cpp/cpp/naked-function-calls)
