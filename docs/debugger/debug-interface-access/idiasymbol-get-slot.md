---
title: "IDiaSymbol::get_slot | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_slot method"
ms.assetid: 97e405b8-483f-4da0-91e7-ca4d88251ecd
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
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