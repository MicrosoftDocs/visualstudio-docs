---
description: "Retrieves a flag indicating whether the function is declared as noexcept."
title: "IDiaSymbol4::get_noexcept"
ms.date: "07/12/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol4::get_noexcept method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol4::get_noexcept

Retrieves a flag indicating whether the function is declared as `noexcept`.

## Syntax

```C++
HRESULT get_noexcept ( 
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` is this function is declared as `noexcept`; otherwise, returns `FALSE`.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol4`](../../debugger/debug-interface-access/idiasymbol4.md)
- [`noexcept` (C++)](/cpp/cpp/noexcept-cpp)
