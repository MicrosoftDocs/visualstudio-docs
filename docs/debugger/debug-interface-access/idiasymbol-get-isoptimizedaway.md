---
description: "Specifies whether the variable is optimized away."
title: "IDiaSymbol::get_isOptimizedAway | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
ms.assetid: c18b1e38-b152-4a13-aba0-59faded5b2e6
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_isOptimizedAway
Specifies whether the variable is optimized away.

## Syntax

```C++
HRESULT get_isOptimizedAway(
   BOOL* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `BOOL` that specifies whether the variable is optimized away.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
