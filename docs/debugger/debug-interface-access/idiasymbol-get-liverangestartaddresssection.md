---
description: "Returns the section part of the starting address of the range in which the local symbol is valid."
title: "IDiaSymbol::get_liveRangeStartAddressSection"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_liveRangeStartAddressSection"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_liveRangeStartAddressSection

Returns the section part of the starting address of the range in which the local symbol is valid.

## Syntax

```C++
HRESULT get_liveRangeStartAddressSection ( 
   DWORD* section
);
```

#### Parameters
 `section`

[out] Returns the section part of the starting address range.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

> [!NOTE]
> A returned error code means that the symbol does not have live range information.

## Remarks
 The address formed by the section and offset is the beginning of the range in which the symbol is valid.

 To get the offset part of the address, use [IDiaSymbol::get_liveRangeStartAddressOffset](../../debugger/debug-interface-access/idiasymbol-get-liverangestartaddressoffset.md).

## Requirements
 Header: Dia2.h

 Library: diaguids.lib

 DLL: msdia100.dll

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
