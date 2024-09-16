---
description: This function retrieves a pointer to a symbol representing the parent/container of this symbol.
title: "IDiaSymbol::get_container"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_container method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_container

This function retrieves a pointer to a symbol representing the parent/container of this symbol.

## Syntax

```C++
HRESULT get_container(
   IDiaSymbol **pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns a pointer to an `IDiaSymbol` containing information about the container of this symbol.

## Return Value
 If successful, returns S_OK; otherwise, returns S_FALSE or an error code.

> [!NOTE]
> A return value of S_FALSE means that the property is not available for the symbol.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v8.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
