---
description: "Specifies whether the this pointer points to a data member with virtual inheritance."
title: "IDiaSymbol::get_isVirtualInheritance"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_isVirtualInheritance

Specifies whether the `this` pointer points to a data member with virtual inheritance.

## Syntax

```C++
HRESULT get_isVirtualInheritance(
   BOOL* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `BOOL` that specifies whether the `this` pointer points to a data member with virtual inheritance.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
