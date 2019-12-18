---
title: "IDiaStackWalkHelper::imageForVA | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkHelper::imageForVA method"
ms.assetid: 8d4edabf-3c01-4fef-8b61-4779f3371067
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
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