---
description: "Retrieves a flag that indicates whether this function has signed return address protections."
title: "IDiaSymbol7::get_isSignRet"
ms.date: "07/12/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol7::get_isSignRet method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol7::get_isSignRet

Retrieves a flag that indicates whether this function has signed return address protections.

## Syntax

```C++
HRESULT get_isSignRet ( 
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` is this function has signed return address protections; otherwise, returns `FALSE`.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol7`](../../debugger/debug-interface-access/idiasymbol7.md)

