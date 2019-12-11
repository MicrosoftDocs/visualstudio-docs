---
title: "IDiaSymbol::get_isSingleInheritance | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
ms.assetid: 46cde656-059b-4c20-9476-3ca68ccc9912
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
---
# IDiaSymbol::get_isSingleInheritance
Specifies whether the `this` pointer points to a data member with single inheritance.

## Syntax

```C++
HRESULT get_isSingleInheritance(
   BOOL* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `BOOL` that specifies whether the `this` pointer points to a data member with single inheritance.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)