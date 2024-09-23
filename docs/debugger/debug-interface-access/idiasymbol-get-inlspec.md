---
description: This function retrieves a flag indicating whether the function was marked as inline (using one of the inline, _inline, __forceinline) attributes).
title: "IDiaSymbol::get_InlSpec"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_InlSpec method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_InlSpec

This function retrieves a flag indicating whether the function was marked as inline (using one of the [inline, __inline, \__forceinline](/cpp/cpp/inline-functions-cpp) attributes).

## Syntax

```C++
HRESULT get_inlSpec(
   BOOL *pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the function was marked as inline; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v8.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [inline, __inline, \__forceinline](/cpp/cpp/inline-functions-cpp)
