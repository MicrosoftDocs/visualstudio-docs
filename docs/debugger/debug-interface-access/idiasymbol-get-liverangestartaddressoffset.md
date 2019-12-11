---
title: "IDiaSymbol::get_liveRangeStartAddressOffset | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_liveRangeStartAddressOffset"
ms.assetid: f5b28914-0a14-4b22-8259-59d7f97ee610
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_liveRangeStartAddressOffset
Returns the offset part of the starting address of the range in which the local symbol is valid.

## Syntax

```C++
HRESULT get_liveRangeStartAddressOffset ( 
   DWORD* offset
);
```

#### Parameters
 `offset`

[out] Returns the offset part of the starting address range.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

> [!NOTE]
> A returned error code means that the symbol does not have live range information.

## Remarks
 The address formed by the section and offset is the beginning of the range in which the symbol is valid.

 To get the section part of the address, use [IDiaSymbol::get_liveRangeStartAddressSection](../../debugger/debug-interface-access/idiasymbol-get-liverangestartaddresssection.md).

## Requirements
 Header: Dia2.h

 Library: diaguids.lib

 DLL: msdia100.dll

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)