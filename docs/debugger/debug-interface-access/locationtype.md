---
description: "Indicates the kind of location information contained in a symbol."
title: "LocationType | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "LocationType enumeration"
ms.assetid: d3e1eedc-bfd3-4c91-881b-d69565138d0f
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# LocationType
Indicates the kind of location information contained in a symbol.

## Syntax

```C++
enum LocationType {
    LocIsNull,
    LocIsStatic,
    LocIsTLS,
    LocIsRegRel,
    LocIsThisRel,
    LocIsEnregistered,
    LocIsBitField,
    LocIsSlot,
    LocIsIlRel,
    LocInMetaData,
    LocIsConstant,
    LocTypeMax
};
```

## Elements
`LocIsNull`
Location information is unavailable.

`LocIsStatic`
Location is static.

`LocIsTLS`
Location is in thread local storage.

`LocIsRegRel`
Location is register-relative.

`LocIsThisRel`
Location is `this`-relative.

`LocIsEnregistered`
Location is in a register.

`LocIsBitField`
Location is in a bit field.

`LocIsSlot`
Location is a Microsoft Intermediate Language (MSIL) slot.

`LocIsIlRel`
Location is MSIL-relative.

`LocInMetaData`
Location is in metadata.

`LocIsConstant`
Location is in a constant value.

`LocTypeMax`
The number of location types in this enumeration.

## Remarks
The properties available to the [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) interface depend on the symbol's location within the image file. For more information, see [Symbol Locations](../../debugger/debug-interface-access/symbol-locations.md).

The values in this enumeration are returned by a call to the [IDiaSymbol::get_locationType](../../debugger/debug-interface-access/idiasymbol-get-locationtype.md) method.

## Requirements
Header: cvconst.h

## See also
- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [IDiaSymbol::get_locationType](../../debugger/debug-interface-access/idiasymbol-get-locationtype.md)
- [Symbol Locations](../../debugger/debug-interface-access/symbol-locations.md)
