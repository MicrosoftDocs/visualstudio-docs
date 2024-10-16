---
description: "Retrieves the offset of the symbol location."
title: "IDiaSymbol::get_offset"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_offset method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_offset

Retrieves the offset of the symbol location. Use when the [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md) is `LocIsRegRel` or `LocIsBitField`.

## Syntax

```C++
HRESULT get_offset ( 
   LONG* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the offset in bytes of the symbol location.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 The offset is from some known point previously determined. For example, the offset for a `LocIsBitField` location type is typically from the start of the containing class.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v7.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md)
