---
description: "Retrieves the offset in the virtual function table of a virtual function."
title: "IDiaSymbol::get_virtualBaseOffset"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_virtualBaseOffset method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_virtualBaseOffset

Retrieves the offset in the virtual function table of a virtual function.

## Syntax

```C++
HRESULT get_virtualBaseOffset ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the offset in the virtual function table of a virtual function.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
