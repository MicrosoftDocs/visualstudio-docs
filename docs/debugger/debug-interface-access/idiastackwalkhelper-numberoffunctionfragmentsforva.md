---
description: Returns the number of discontiguous fragments for the function at the specified virtual address (VA).
title: "IDiaStackWalkHelper::getNumberOfFunctionFragmentsForVA"
ms.date: "11/04/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkHelper::getNumberOfFunctionFragmentsForVA method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaStackWalkHelper::getNumberOfFunctionFragmentsForVA

Returns the number of discontiguous fragments for the function at the specified virtual address (VA).

## Syntax

```C++
HRESULT getNumberOfFunctionFragmentsForVA(
    ULONGLONG vaFunc,
    DWORD cbFunc,
    DWORD *pNumFragments
);
```

### Parameters

 `[in] vaFunc`

 The virtual address of the function.

 `[in] cbFunc`

 The total size in bytes of the function (that is, the length of the function).

 `[out] pNumFragments`

 The number of fragments.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaStackWalkHelper`](../../debugger/debug-interface-access/idiastackwalkhelper.md)
- [`IDiaSession::getNumberOfFunctionFragments_VA`](../../debugger/debug-interface-access/idiasession-getnumberoffunctionfragments_va.md)
