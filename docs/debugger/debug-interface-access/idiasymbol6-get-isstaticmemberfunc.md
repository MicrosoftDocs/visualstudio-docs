---
description: "Retrieves a flag that indicates whether this function is a static member function."
title: "IDiaSymbol6::get_isStaticMemberFunc"
ms.date: "07/12/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol6::get_isStaticMemberFunc method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol6::get_isStaticMemberFunc

Retrieves a flag that indicates whether this function is a static member function.

## Syntax

```C++
HRESULT get_isStaticMemberFunc ( 
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` if this is a static member function; otherwise, returns `FALSE`.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol6`](../../debugger/debug-interface-access/idiasymbol6.md)
- [`noexcept` (C++)](/cpp/cpp/noexcept-cpp)
