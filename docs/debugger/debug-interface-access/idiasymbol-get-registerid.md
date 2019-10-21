---
title: "IDiaSymbol::get_registerId | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_registerId method"
ms.assetid: f881e793-eb9e-48dc-a847-dd61d77174fc
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_registerId
Retrieves the register designator of the location when the [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md) is set to `LocIsEnregistered`.

## Syntax

```C++
HRESULT get_registerId ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the register designator of the location.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Remarks
 If the symbol is relative to a register, that is, if the symbol's [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md) is set to `LocIsRegRel`, use the `get_registerId` method followed by a call to the [IDiaSymbol::get_offset](../../debugger/debug-interface-access/idiasymbol-get-offset.md) method to get the offset from the register where the symbol is located.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md)