---
description: "Retrieves the slot number of the location."
title: "IDiaSymbol::get_slot"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_slot method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_slot

Retrieves the slot number of the location. Use when the [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md) is `LocIsSlot`.

## Syntax

```C++
HRESULT get_slot ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the slot number of the location.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md)
