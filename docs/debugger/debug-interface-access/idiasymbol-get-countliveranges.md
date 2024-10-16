---
description: Retrieves the number of valid address ranges associated with the local symbol.
title: "IDiaSymbol::get_countLiveRanges"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_countLiveRanges"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
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
