---
description: "Specifies whether the variable carries a return value."
title: "IDiaSymbol::get_isReturnValue | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
ms.assetid: 37aaf48a-65cb-4ec2-823e-1c637a9f939c
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_isReturnValue
Specifies whether the variable carries a return value.

## Syntax

```C++
HRESULT get_isReturnValue(
   BOOL* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `BOOL` that specifies whether the variable carries a return value.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
