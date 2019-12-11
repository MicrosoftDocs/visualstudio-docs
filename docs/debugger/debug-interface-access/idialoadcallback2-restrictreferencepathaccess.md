---
title: "IDiaLoadCallback2::RestrictReferencePathAccess | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLoadCallback2::RestrictReferencePathAccess method"
ms.assetid: e20cb45c-0360-4ff0-a92c-b1b6f76d6e85
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaLoadCallback2::RestrictReferencePathAccess
Determines if looking for a .pdb file is allowed in the path where the .exe file is located.

## Syntax

```C++
HRESULT RestrictReferencePathAccess();
```

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Any return code other than `S_OK` to prevent looking for a .pdb file in the path where the .exe file is located.

## See also
- [IDiaLoadCallback2](../../debugger/debug-interface-access/idialoadcallback2.md)