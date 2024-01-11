---
description: "Called when a candidate .pdb file is opened."
title: "IDiaLoadCallback::NotifyOpenPDB"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLoadCallback::NotifyOpenPDB method"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.subservice: debug-diagnostics
---
# IDiaLoadCallback::NotifyOpenPDB

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Called when a candidate .pdb file is opened.

## Syntax

```C++
HRESULT NotifyOpenPDB ( 
   LPCOLESTR pdbPath,
   HRESULT   resultCode
);
```

#### Parameters
 `pdbPath`

[in] The full path of the .pdb file.

 `resultCode`

[in] Code that indicates the success (`S_OK`) or failure of the load as applied to this file.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code. The return code is typically ignored.

## See also
- [IDiaLoadCallback2](../../debugger/debug-interface-access/idialoadcallback2.md)
