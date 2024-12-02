---
description: "Specifies whether this symbol is a pointer to a member function."
title: "IDiaSymbol::get_isPointerToMemberFunction"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_isPointerToMemberFunction

Specifies whether this symbol is a pointer to a member function.

## Syntax

```C++
HRESULT get_isPointerToMemberFunction(
   BOOL* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `BOOL` that specifies whether this symbol is a pointer to a member function.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
