---
description: "Retrieves the file name of the library or object file from which the object was loaded."
title: "IDiaSymbol::get_libraryName"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_libraryName method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_libraryName

Retrieves the file name of the library or object file from which the object was loaded.

## Syntax

```C++
HRESULT get_libraryName ( 
   BSTR* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the file name of the library or object file from which the object was loaded.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
