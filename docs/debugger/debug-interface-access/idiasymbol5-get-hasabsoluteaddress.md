---
description: "Retrieves a flag that indicates whether this symbol has an absolute address."
title: "IDiaSymbol5::get_hasAbsoluteAddress"
ms.date: "07/12/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol5::get_hasAbsoluteAddress method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol5::get_hasAbsoluteAddress

Retrieves a flag that indicates whether this symbol has an absolute address.

## Syntax

```C++
HRESULT get_hasAbsoluteAddress ( 
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` if this symbol has an absolute address; otherwise, returns `FALSE`.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol5`](../../debugger/debug-interface-access/idiasymbol5.md)
- [`noexcept` (C++)](/cpp/cpp/noexcept-cpp)
