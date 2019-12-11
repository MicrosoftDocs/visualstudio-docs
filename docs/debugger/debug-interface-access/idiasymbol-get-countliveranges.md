---
title: "IDiaSymbol::get_countLiveRanges | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_countLiveRanges"
ms.assetid: 55f79e1a-d4c2-42cd-ab37-d8253b20e34c
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_countLiveRanges
Retrieves the number of valid address ranges associated with the local symbol.

## Syntax

```C++
HRESULT get_countLiveRanges ( 
   DWORD* count
);
```

#### Parameters
 `count`

[out] Returns the number of address ranges.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Requirements
 Header: Dia2.h

 Library: diaguids.lib

 DLL: msdia100.dll

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)