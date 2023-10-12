---
description: "Determines if looking for a .pdb file is allowed in the path where the .exe file is located."
title: "IDiaLoadCallback2::RestrictReferencePathAccess"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLoadCallback2::RestrictReferencePathAccess method"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
---
# IDiaLoadCallback2::RestrictReferencePathAccess

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
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
