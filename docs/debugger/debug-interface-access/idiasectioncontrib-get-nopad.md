---
description: Retrieves a flag indicating whether the section should not be padded to the next memory boundary.
title: "IDiaSectionContrib::get_nopad"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSectionContrib::get_nopad method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSectionContrib::get_nopad

Retrieves a flag indicating whether the section should not be padded to the next memory boundary.

## Syntax

```C++
HRESULT get_nopad(
   BOOL* pRetVal
};
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the section should not be padded to the next memory boundary; otherwise returns `FALSE`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## Remarks
 This is a property typically seen only on older files.

## See also
- [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)
