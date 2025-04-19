---
description: Retrieves the variable classification of a data symbol.
title: "IDiaSymbol::get_dataKind"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_dataKind method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_dataKind

Retrieves the variable classification of a data symbol.

## Syntax

```C++
HRESULT get_dataKind ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns a value from the [DataKind Enumeration](../../debugger/debug-interface-access/datakind.md) enumeration specifying the kind of data such as global, static, or constant, for example.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v7.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [DataKind Enumeration](../../debugger/debug-interface-access/datakind.md)
