---
title: "IDiaSymbol::get_isMatrixRowMajor | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
ms.assetid: 36b1e881-ea76-48b0-b67f-e9eb0d19bec7
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_isMatrixRowMajor
Specifies whether the matrix is row major.

## Syntax

```C++
HRESULT get_isMatrixRowMajor(
   BOOL* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `BOOL` that specifies whether the matrix is row major.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)