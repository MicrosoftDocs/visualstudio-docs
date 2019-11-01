---
title: "IDiaSymbol::get_rank | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_rank method"
ms.assetid: 14cc9c4b-a5ec-414a-b01f-4a142c17b7cc
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_rank
Retrieves the rank (number of dimensions) of a FORTRAN multi-dimensional array.

## Syntax

```C++
HRESULT get_rank ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the number of dimensions in a FORTRAN multi-dimensional array.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 Rank refers to the number of dimensions in an array where the array is declared as `myarray[1,2,3]`. This example has a rank of 3 and 3 dimensions. Rank does not apply to C++ which uses the concept of an array of arrays for each dimension (that is, `myarray[1][2][3]`).

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)