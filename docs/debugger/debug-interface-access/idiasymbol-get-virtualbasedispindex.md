---
description: "Retrieves the index of the symbol in the virtual base displacement table."
title: "IDiaSymbol::get_virtualBaseDispIndex"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_virtualBaseDispIndex method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_virtualBaseDispIndex

Retrieves the index of the symbol in the virtual base displacement table.

## Syntax

```C++
HRESULT get_virtualBaseDispIndex (
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the index into the virtual base displacement table.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
