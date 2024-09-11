---
description: "Retrieves a Boolean indicating that the source debug information was produced with /DEBUG:fastlink."
title: "IDiaSessionEx::isFastLinkPDB"
ms.date: "07/05/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSessionEx::isFastLinkPDB method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSessionEx::isFastLinkPDB

Retrieves a Boolean indicating that the source debug information was produced with `/DEBUG:fastlink`.

## Syntax

```C++
HRESULT isFastLinkPDB(
    BOOL* pfFastLinkPDB
);
```

#### Parameters

 `pfFastLinkPDB`

[out] Returns a Boolean indcating if the debug information was build with `/DEBUG:fastlink` or not.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks

If debug information was compiled with `/DEBUG:fastlink` then not all of the inforation is contained within the `.PDB` and in order fo the debugger to fully work, it must access the debug inforation contained within oms of the intermediate build files (like `.OBJ`, `.LIB`, and `.PCH` files). Fastlink PDBs are no longer recommended.

## See also

- [/DEBUG (Generate debug info)](/cpp/build/reference/debug-generate-debug-info)
- [`IDiaSessionEx`](../../debugger/debug-interface-access/idiasessionex.md)
