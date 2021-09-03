---
description: "Retrieves the number of modifiers that are applied to the original type."
title: "IDiaSymbol::get_numberOfModifiers | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
ms.assetid: 61ff7431-1994-4f7e-a182-1817f16f60a9
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_numberOfModifiers
Retrieves the number of modifiers that are applied to the original type.

## Syntax

```C++
HRESULT get_numberOfModifiers(
   DWORD* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `DWORD` that specifies the number of modifiers that are applied to the original type.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
