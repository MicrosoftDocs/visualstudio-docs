---
description: "Determines if looking for debug information is allowed from .dbg files."
title: "IDiaLoadCallback2::RestrictDBGAccess"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLoadCallback2::RestrictDBGAccess method"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
---
# IDiaLoadCallback2::RestrictDBGAccess

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
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
