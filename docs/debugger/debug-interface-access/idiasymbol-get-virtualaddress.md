---
description: "Retrieves the virtual address (VA) of the location."
title: "IDiaSymbol::get_virtualAddress"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_virtualAddress method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_virtualAddress

Retrieves the virtual address (VA) of the location. Use when the [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md) is set to `LocIsStatic`.

## Syntax

```C++
HRESULT get_virtualAddress ( 
   ULONGLONG* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the virtual address of the location.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md)
