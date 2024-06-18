---
description: Determines if looking for debug information is allowed from .dbg files.
title: "IDiaLoadCallback2::RestrictDBGAccess"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLoadCallback2::RestrictDBGAccess method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaLoadCallback2::RestrictDBGAccess

Determines if looking for debug information is allowed from .dbg files.

## Syntax

```c++
HRESULT RestrictDBGAccess();
```

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks

Any return value other than `S_OK` to prevent looking for debug information from .dbg files.

## See also

- [IDiaLoadCallback2](../../debugger/debug-interface-access/idialoadcallback2.md)
