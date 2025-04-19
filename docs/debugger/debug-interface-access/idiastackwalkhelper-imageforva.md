---
description: Returns the start of an executable's image in memory given a virtual address somewhere in the executable's memory space.
title: "IDiaStackWalkHelper::imageForVA"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkHelper::imageForVA method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaStackWalkHelper::imageForVA

Returns the start of an executable's image in memory given a virtual address somewhere in the executable's memory space.

## Syntax

```C++
HRESULT imageForVA(
   ULONGLONG  vaContext,
   ULONGLONG *pvaImageStart
);
```

#### Parameters
 `vaContext`

[in] The virtual address that lies somewhere in the executable's space.

 `pvaImageStart`

[out] Returns the starting virtual address of the executable's image.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaStackWalkHelper](../../debugger/debug-interface-access/idiastackwalkhelper.md)
