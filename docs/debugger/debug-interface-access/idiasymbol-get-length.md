---
description: "Retrieves the number of bits or bytes of memory used by the object represented by this symbol."
title: "IDiaSymbol::get_length"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_length method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_length

Retrieves the number of bits or bytes of memory used by the object represented by this symbol.

## Syntax

```C++
HRESULT get_length ( 
   ULONGLONG* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the number of bytes or bits of memory used by the object represented by this symbol.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 If the [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md) of the symbol is `LocIsBitField`, the length returned by this method is in bits; otherwise, the length is in bytes for all other location types.

## Example

```C++
IDiaSymbol* pSymbol;
ULONGLONG   length;
pSymbol->get_length( &length );
```

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v7.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md)
