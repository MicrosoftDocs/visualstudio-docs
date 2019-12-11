---
title: "IDiaSymbol::get_classParentId | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_classParentId method"
ms.assetid: f11e3ccb-215d-418c-b8c3-e63159234915
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_classParentId
Retrieves the class parent identifier of the symbol.

## Syntax

```C++
HRESULT get_classParentId ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the class parent ID of the symbol.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 The identifier is a unique value created by the DIA SDK to mark all symbols as unique.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v7.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)