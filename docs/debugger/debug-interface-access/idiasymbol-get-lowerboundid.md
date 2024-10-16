---
description: "Retrieves the symbol identifier of the lower bound of a FORTRAN array dimension."
title: "IDiaSymbol::get_lowerBoundId"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_lowerBoundId method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_lowerBoundId

Retrieves the symbol identifier of the lower bound of a FORTRAN array dimension.

## Syntax

```C++
HRESULT get_lowerBoundId ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the symbol ID of the symbol that represents the lower bound of a FORTRAN array dimension.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 The identifier is a unique value created by the DIA SDK to mark all symbols as unique.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
