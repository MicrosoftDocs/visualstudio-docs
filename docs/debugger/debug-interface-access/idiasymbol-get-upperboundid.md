---
description: "Retrieves the symbol identifier of the upper bound of a FORTRAN array dimension."
title: "IDiaSymbol::get_upperBoundId | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_upperBoundId method"
ms.assetid: ddfa1617-bd0f-4187-ba77-a225bab93a95
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_upperBoundId
Retrieves the symbol identifier of the upper bound of a FORTRAN array dimension.

## Syntax

```C++
HRESULT get_upperBoundId ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`
- [out,] Returns the ID of the symbol that represents the upper bound of a FORTRAN array dimension.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 The identifier is a unique value created by the DIA SDK to mark all symbols as unique.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
