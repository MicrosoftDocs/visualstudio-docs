---
description: Retrieves a flag that indicates whether the segment is executable.
title: "IDiaSegment::get_execute"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSegment::get_execute method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSegment::get_execute

Retrieves a flag that indicates whether the segment is executable.

## Syntax

```C++
HRESULT get_execute ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the segment is marked as executable; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md)
