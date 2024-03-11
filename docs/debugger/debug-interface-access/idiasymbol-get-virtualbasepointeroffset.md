---
description: "Retrieves the offset of the virtual base pointer."
title: "IDiaSymbol::get_virtualBasePointerOffset"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_virtualBasePointerOffset method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_virtualBasePointerOffset

Retrieves the offset of the virtual base pointer.

## Syntax

```C++
HRESULT get_virtualBasePointerOffset ( 
   LONG* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the offset of the virtual base pointer.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
