---
description: "Retrieves the number of columns in the matrix."
title: "IDiaSymbol::get_numberOfColumns | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
ms.assetid: 64834351-e2c9-4f1c-9dc0-2abb5478bc63
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_numberOfColumns
Retrieves the number of columns in the matrix.

## Syntax

```C++
HRESULT get_numberOfColumns(
   DWORD* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `DWORD` that holds the number of columns in the matrix.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
