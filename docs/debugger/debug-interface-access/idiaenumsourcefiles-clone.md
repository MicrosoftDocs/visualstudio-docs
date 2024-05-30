---
description: Creates an enumerator that contains the same enumeration state as the current source files enumerator.
title: "IDiaEnumSourceFiles::Clone"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSourceFiles::Clone method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumSourceFiles::Clone

Creates an enumerator that contains the same enumeration state as the current enumerator.

## Syntax

```c++
HRESULT Clone ( 
   IDiaEnumSourceFiles** ppenum
);
```

#### Parameters

ppenum

[out] Returns an [IDiaEnumSourceFiles](../../debugger/debug-interface-access/idiaenumsourcefiles.md) object that contains a duplicate of the enumerator. The source files are not duplicated, only the enumerator.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [IDiaEnumSourceFiles](../../debugger/debug-interface-access/idiaenumsourcefiles.md)
