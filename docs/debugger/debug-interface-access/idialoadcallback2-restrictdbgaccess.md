---
title: "IDiaLoadCallback2::RestrictDBGAccess | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLoadCallback2::RestrictDBGAccess method"
ms.assetid: 63b67a93-2910-4fff-aa70-6b2eaa08e5c8
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaLoadCallback2::RestrictDBGAccess
Determines if looking for debug information is allowed from .dbg files.

## Syntax

```C++
HRESULT RestrictDBGAccess();
```

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Any return value other than `S_OK` to prevent looking for debug information from .dbg files.

## See also
- [IDiaLoadCallback2](../../debugger/debug-interface-access/idialoadcallback2.md)