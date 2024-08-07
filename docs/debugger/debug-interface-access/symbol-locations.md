---
description: "Most symbols have a defined location within the image file."
title: "Symbol Locations"
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "LocationType values"
  - "symbols [DIA SDK], locations"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Symbol Locations

Most symbols have a defined location within the image file. A symbol's location is specified with a value from the [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md) enumeration. The symbol may support additional properties depending on its location.

 The following table shows the most commonly used location types and their additional properties.

|Location type|Additional properties|
|-------------------|---------------------------|
|`LocIsNull`|none|
|`LocIsStatic`|[`IDiaSymbol::get_addressOffset`](../../debugger/debug-interface-access/idiasymbol-get-addressoffset.md)<br /><br /> [`IDiaSymbol::get_addressSection`](../../debugger/debug-interface-access/idiasymbol-get-addresssection.md)<br /><br /> [`IDiaSymbol::get_relativeVirtualAddress`](../../debugger/debug-interface-access/idiasymbol-get-relativevirtualaddress.md) (if relative virtual addresses are enabled)<br /><br /> [`IDiaSymbol::get_virtualAddress`](../../debugger/debug-interface-access/idiasymbol-get-virtualaddress.md) (if the image base has been set to nonzero)|
|`LocIsTLS`|[`IDiaSymbol::get_addressSection`](../../debugger/debug-interface-access/idiasymbol-get-addresssection.md)<br /><br /> [`IDiaSymbol::get_addressOffset`](../../debugger/debug-interface-access/idiasymbol-get-addressoffset.md)|
|`LocIsRegRel`|[`IDiaSymbol::get_registerId`](../../debugger/debug-interface-access/idiasymbol-get-registerid.md)<br /><br /> [`IDiaSymbol::get_offset`](../../debugger/debug-interface-access/idiasymbol-get-offset.md)|
|`LocIsThisRel`|[`IDiaSymbol::get_offset`](../../debugger/debug-interface-access/idiasymbol-get-offset.md)|
|`LocIsEnregistered`|[`IDiaSymbol::get_registerId`](../../debugger/debug-interface-access/idiasymbol-get-registerid.md)|
|`LocIsBitField`|[`IDiaSymbol::get_bitPosition`](../../debugger/debug-interface-access/idiasymbol-get-bitposition.md)<br /><br /> [`IDiaSymbol::get_length`](../../debugger/debug-interface-access/idiasymbol-get-length.md)<br /><br /> [`IDiaSymbol::get_offset`](../../debugger/debug-interface-access/idiasymbol-get-offset.md)|
|`LocIsSlot`|[`IDiaSymbol::get_slot`](../../debugger/debug-interface-access/idiasymbol-get-slot.md)|
|`LocIsIlRel`|[`IDiaSymbol::get_offset`](../../debugger/debug-interface-access/idiasymbol-get-offset.md)|
|`LocInMetaData`|[`IDiaSymbol::get_token`](../../debugger/debug-interface-access/idiasymbol-get-token.md)|
|`LocIsConstant`|[`IDiaSymbol::get_value`](../../debugger/debug-interface-access/idiasymbol-get-value.md)|
|`LocIsRegRelAliasIndir`|[`IDiaSymbol::get_registerId`](../../debugger/debug-interface-access/idiasymbol-get-registerid.md)<br /><br /> [`IDiaSymbol::get_offset`](../../debugger/debug-interface-access/idiasymbol-get-offset.md)<br /><br /> [`IDiaSymbol::get_offsetInUdt`](../../debugger/debug-interface-access/idiasymbol-get-offsetinudt.md)|

## See also

- [`IDiaSymbol::get_addressOffset`](../../debugger/debug-interface-access/idiasymbol-get-addressoffset.md)
- [`IDiaSymbol::get_addressSection`](../../debugger/debug-interface-access/idiasymbol-get-addresssection.md)
- [`IDiaSymbol::get_bitPosition`](../../debugger/debug-interface-access/idiasymbol-get-bitposition.md)
- [`IDiaSymbol::get_length`](../../debugger/debug-interface-access/idiasymbol-get-length.md)
- [`IDiaSymbol::get_locationType`](../../debugger/debug-interface-access/idiasymbol-get-locationtype.md)
- [`IDiaSymbol::get_offset`](../../debugger/debug-interface-access/idiasymbol-get-offset.md)
- [`IDiaSymbol::get_offsetInUdt`](../../debugger/debug-interface-access/idiasymbol-get-offsetinudt.md)
- [`IDiaSymbol::get_registerId`](../../debugger/debug-interface-access/idiasymbol-get-registerid.md)
- [`IDiaSymbol::get_relativeVirtualAddress`](../../debugger/debug-interface-access/idiasymbol-get-relativevirtualaddress.md)
- [`IDiaSymbol::get_slot`](../../debugger/debug-interface-access/idiasymbol-get-slot.md)
- [`IDiaSymbol::get_token`](../../debugger/debug-interface-access/idiasymbol-get-token.md)
- [`IDiaSymbol::get_value`](../../debugger/debug-interface-access/idiasymbol-get-value.md)
- [`IDiaSymbol::get_virtualAddress`](../../debugger/debug-interface-access/idiasymbol-get-virtualaddress.md)
- [`LocationType` Enumeration](../../debugger/debug-interface-access/locationtype.md)
- [Symbols and Symbol Tags](../../debugger/debug-interface-access/symbols-and-symbol-tags.md)
