---
description: Retrieves a flag that indicates whether the section cannot be paged out of memory.
title: "IDiaSectionContrib::get_notPaged"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSectionContrib::get_notPaged method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSectionContrib::get_notPaged

Retrieves a flag that indicates whether the section cannot be paged out of memory.

## Syntax

```C++
HRESULT get_notPaged ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`
- [out, retval] Returns `TRUE` if the section cannot be paged out; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)
