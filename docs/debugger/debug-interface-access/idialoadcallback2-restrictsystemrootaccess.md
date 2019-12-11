---
title: "IDiaLoadCallback2::RestrictSystemRootAccess | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLoadCallback2::RestrictSystemRootAccess method"
ms.assetid: 39f22db8-632a-4ef0-babc-23f758e6d937
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaLoadCallback2::RestrictSystemRootAccess
Determines if searching for .pdb files is allowed in the system root directory.

## Syntax

```C++
HRESULT RestrictSystemRootAccess();
```

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Any return code other than `S_OK` prevents searching the system root for .pdb files.

## See also
- [IDiaLoadCallback2](../../debugger/debug-interface-access/idialoadcallback2.md)