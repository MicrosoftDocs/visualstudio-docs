---
description: Retrieves a flag that specifies whether the function contains a call to alloca (which is used to allocate memory on the stack).
title: "IDiaSymbol::get_hasAlloca"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_hasAlloca method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_hasAlloca

Retrieves a flag that specifies whether the function contains a call to `alloca` (which is used to allocate memory on the stack).

## Syntax

```cpp
HRESULT get_hasAlloca(   BOOL *pFlag);
```

#### Parameters
 `pFlag`

[out] Returns `TRUE` if the function contains a call to `alloca`; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v8.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
