---
description: "Indicates the kind of location information contained in a symbol."
title: "LocationType"
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "LocationType enumeration"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# `LocationType`

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
    LocIsRegRelAliasIndir,
    LocTypeMax
};
```

## Elements

| Element             | Description                                                |
| ------------------- | ---------------------------------------------------------- |
| `LocIsNull`         | Location information is unavailable.                       |
| `LocIsStatic`       | Location is static.                                        |
| `LocIsTLS`          | Location is in thread local storage.                       |
| `LocIsRegRel`       | Location is register-relative.                             |
| `LocIsThisRel`      | Location is `this`-relative.                               |
| `LocIsEnregistered` | Location is in a register.                                 |
| `LocIsBitField`     | Location is in a bit field.                                |
| `LocIsSlot`         | Location is a Microsoft Intermediate Language (MSIL) slot. |
| `LocIsIlRel`        | Location is MSIL-relative.                                 |
| `LocInMetaData`     | Location is in metadata.                                   |
| `LocIsConstant`     | Location is in a constant value.                           |
| `LocIsRegRelAliasIndir` | Location is register-relative, and an alias for part of a user defined type (UDT) . |
| `LocTypeMax`        | The number of location types in this enumeration.          |

## Remarks

The properties available to the [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md) interface depend on the symbol's location within the image file. For more information, see [Symbol Locations](../../debugger/debug-interface-access/symbol-locations.md).

The values in this enumeration are returned by a call to the [`IDiaSymbol::get_locationType`](../../debugger/debug-interface-access/idiasymbol-get-locationtype.md) method.

## Requirements

Header: cvconst.h

## See also

- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`IDiaSymbol::get_locationType`](../../debugger/debug-interface-access/idiasymbol-get-locationtype.md)
- [Symbol Locations](../../debugger/debug-interface-access/symbol-locations.md)
