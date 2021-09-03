---
description: "Retrieves the number of rows in the matrix."
title: "IDiaSymbol::get_numberOfRows | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
ms.assetid: cf3eb110-d07f-4995-b68b-08290aa67d6f
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_numberOfRows
Retrieves the number of rows in the matrix.

## Syntax

```C++
HRESULT get_numberOfRows(
   DWORD* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `DWORD` that holds the number of rows in the matrix.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
