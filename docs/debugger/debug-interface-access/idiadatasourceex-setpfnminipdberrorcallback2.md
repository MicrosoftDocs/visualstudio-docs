---
description: Sets a callback function to receive errors relating to loading secondary files referenced from fastlink PDBs.
title: "IDiaDataSourceEx::setPfnMiniPDBErrorCallback"
ms.date: "7/2/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaDataSourceEx::setPfnMiniPDBErrorCallback method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaDataSourceEx::setPfnMiniPDBErrorCallback

Sets a callback function to receive errors relating to loading secondary files (.OBJ, .LIB, or compiler generated .PDB  files) referenced from fastlink PDBs (that is, PDBs generated with `/DEBUG:fastlink`).

## Syntax

```c++
HRESULT setpfnminipdberrorcallback2 (
   void* pvContext,
   PFNMINIPDBERRORCALLBACK2 pfn
);
```

#### Parameters

`pvContext`

[in] A context parameter to be passed to the callback.

`pfn`

[in] A pointer to a function to be called.

## Return Value

If successful, returns `S_OK`.

## Remarks

PDBs that are generated with /DEBUG:fastlink (also sometimes call mini PDBs), do not contain all the debug information and instead must read information out of the OBJs, LIBs and compiler generated PDBs used to make the final executable. If errors occur when trying to loacte or read those files, a callback maybe set to receive additional information about the failure.

Only one callback function may be registered at a time. Attempting to register a second function will simply replace the first. To remove the registration, simply pass a `nullptr` for both arguments.

See [`PFNMINIPDBERRORCALLBACK2`](../../debugger/debug-interface-access/pfnminipdberrorcallback2.md) for an example of using this method.

## See also

- [`IDiaDataSourceEx`](../../debugger/debug-interface-access/idiadatasourceex.md)
- [`PFNMINIPDBERRORCALLBACK2`](../../debugger/debug-interface-access/pfnminipdberrorcallback2.md)
- [/DEBUG (Generate debug info)](/cpp/build/reference/debug-generate-debug-info)
