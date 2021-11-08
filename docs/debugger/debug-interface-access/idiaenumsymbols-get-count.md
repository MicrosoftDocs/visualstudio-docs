---
description: "Retrieves the number of symbols."
title: "IDiaEnumSymbols::get_Count | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSymbols::get_Count method"
ms.assetid: fdaae6d7-e67b-4262-84c9-fbae381e8297
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaEnumSymbols::get_Count
Retrieves the number of symbols.

## Syntax

```C++
HRESULT get_Count ( 
   LONG* pRetVal
);
```

#### Parameters
 pRetVal

[out] Returns the number of symbols.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md)
- [IDiaEnumSymbols::Item](../../debugger/debug-interface-access/idiaenumsymbols-item.md)
