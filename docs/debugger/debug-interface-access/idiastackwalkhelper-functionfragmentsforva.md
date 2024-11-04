---
description: Returns the addresses and lengths of discontiguous fragments for the function at the specified virtual address (VA).
title: "IDiaStackWalkHelper::getFunctionFragmentsForVA"
ms.date: "11/04/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSesIDiaStackWalkHelpersion::getFunctionFragmentsForVA method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaStackWalkHelper::getFunctionFragmentsForVA

Returns the addresses and lengths of discontiguous fragments for the function at the specified virtual address (VA).

## Syntax

```C++
HRESULT getFunctionFragmentsVA(
    ULONGLONG vaFunc,
    DWORD cbFunc,
    DWORD cFragments,
    ULONGLONG *pVaFragment,
    DWORD *pLenFragment
);
```

### Parameters

 `[in] vaFunc`

 The virtual address of the function.

 `[in] cbFunc`

 The total size in bytes of the function (that is, the length of the function).

 `[in] cFragments`

 The count of elements allocated for `pVaFragment` and `pLenFragment`.

 `[out] pVaFragment`

 Array buffer to receive the virtual addresses of each fragment. This buffer must be at least `cFragments` elements long.

 `[out] pLenFragment`

 Array buffer to receive the length, in bytes, of each fragment. This buffer must be at least `cFragments` elements long.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaStackWalkHelper`](../../debugger/debug-interface-access/idiastackwalkhelper.md)
- [`IDiaSession::getFunctionFragments_VA`](../../debugger/debug-interface-access/idiasession-getfunctionfragments_va.md)
