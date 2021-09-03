---
description: "Retrieves the unique symbol identifier."
title: "IDiaSymbol::get_symIndexId | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_symIndexId method"
ms.assetid: dd1fb3ba-31bf-497d-a6bf-79f1206e6642
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_symIndexId
Retrieves the unique symbol identifier.

## Syntax

```C++
HRESULT get_symIndexId ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the symbol ID of the symbol.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 The identifier is a unique value created by the DIA SDK to mark all symbols as unique.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
