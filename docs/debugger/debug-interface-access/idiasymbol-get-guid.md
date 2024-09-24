---
description: Retrieves the symbol's globally unique identifier (GUID).
title: "IDiaSymbol::get_guid"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_guid method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_guid

Retrieves the symbol's globally unique identifier (GUID).

## Syntax

```C++
HRESULT get_guid ( 
   GUID* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the symbol's GUID.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v7.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
