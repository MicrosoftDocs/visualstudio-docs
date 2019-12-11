---
title: "IDiaSymbol::get_arrayIndexTypeId | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_arrayIndexTypeId method"
ms.assetid: 124f86e2-6f66-4541-87c3-799f435b731e
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_arrayIndexTypeId
Retrieves the array index type identifier of the symbol.

## Syntax

```C++
HRESULT get_arrayIndexTypeId ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the array index type ID of the symbol.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Remarks
 The identifier is a unique value created by the DIA SDK to mark all symbols as unique.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v7.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)