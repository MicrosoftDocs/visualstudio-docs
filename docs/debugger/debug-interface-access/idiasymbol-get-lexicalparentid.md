---
description: "Retrieves the lexical parent identifier of the symbol."
title: "IDiaSymbol::get_lexicalParentId"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_lexicalParentId method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_lexicalParentId

Retrieves the lexical parent identifier of the symbol.

## Syntax

```C++
HRESULT get_lexicalParentId ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the lexical parent ID of the symbol.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 The identifier is a unique value created by the DIA SDK to mark all symbols as unique.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
