---
description: Retrieves a flag that indicates whether the section contains 16-bit code.
title: "IDiaSectionContrib::get_code16bit"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSectionContrib::get_code16bit method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSectionContrib::get_code16bit

Retrieves a flag that indicates whether the section contains 16-bit code.

## Syntax

```C++
HRESULT get_code16bit(
   BOOL *pRetVal
};
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the code in the section is 16-bit; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method only indicates if the code is 16-bit. If the code is not 16-bit, it could be anything else, such as 32-bit or 64-bit code.

## See also
- [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)
