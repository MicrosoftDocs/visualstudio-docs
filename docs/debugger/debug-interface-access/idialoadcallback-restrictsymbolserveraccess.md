---
description: Determines if access is allowed to a symbol server to resolve symbols.
title: "IDiaLoadCallback::RestrictSymbolServerAccess"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLoadCallback::RestrictSymbolServerAccess method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaLoadCallback::RestrictSymbolServerAccess

Determines if access is allowed to a symbol server to resolve symbols.

## Syntax

```c++
HRESULT RestrictSymbolServerAccess();
```

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks

Any return code other than `S_OK` prevents use of a symbol server to resolve symbols.

## See also

- [IDiaLoadCallback2](../../debugger/debug-interface-access/idialoadcallback2.md)
