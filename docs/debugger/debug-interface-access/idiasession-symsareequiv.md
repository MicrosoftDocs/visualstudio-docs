---
description: Checks to see if two symbols are equivalent.
title: "IDiaSession::symsAreEquiv"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::symsAreEquiv method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSession::symsAreEquiv

Checks to see if two symbols are equivalent.

## Syntax

```C++
HRESULT symsAreEquiv ( 
   IDiaSymbol* symbolA,
   IDiaSymbol* symbolB
);
```

#### Parameters
 `symbolA`

[in] The first [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object used in the comparison.

 `symbolB`

[in] The second `IDiaSymbol` object used in the comparison.

## Return Value
 If the symbols are equivalent, returns `S_OK`; otherwise, returns `S_FALSE`, the symbols are not equivalent. Otherwise, return an error code.

## See also
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
