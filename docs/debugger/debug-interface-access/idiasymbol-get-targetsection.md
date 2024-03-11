---
description: "Retrieves the address section of a thunk target."
title: "IDiaSymbol::get_targetSection"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_targetSection method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_targetSection

Retrieves the address section of a thunk target.

## Syntax

```C++
HRESULT get_targetSection ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Section part of a thunk target address.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
