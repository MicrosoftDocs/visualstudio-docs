---
description: Retrieves the age value of a .pdb file.
title: "IDiaSymbol::get_age"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_age method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_age

Retrieves the age value of a .pdb file.

## Syntax

```C++
HRESULT get_age ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the age value of a .pdb file.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 The age does not necessarily correspond to any known time value; it is typically used to determine if a .pdb file is out of sync with a corresponding .exe file.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v7.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
