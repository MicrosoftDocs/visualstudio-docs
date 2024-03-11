---
description: "Specifies whether the this pointer is flagged as restricted."
title: "IDiaSymbol::get_restrictedType"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_restrictedType

Specifies whether the `this` pointer is flagged as restricted.

## Syntax

```C++
HRESULT get_restrictedType(
   BOOL* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `BOOL` that specifies whether the `this` pointer is flagged as restricted.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
