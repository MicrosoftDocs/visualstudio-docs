---
description: Retrieves a reference to the symbol for the compiland that contributed the bytes of image text.
title: "IDiaLineNumber::get_compiland"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLineNumber::get_compiland method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaLineNumber::get_compiland

Retrieves a reference to the symbol for the compiland that contributed the bytes of image text.

## Syntax

```c++
HRESULT get_compiland ( 
   IDiaSymbol** pRetVal
);
```

#### Parameters

pRetVal

[out] Returns an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object for the compiland that contributed the bytes of image text.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also

- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)
