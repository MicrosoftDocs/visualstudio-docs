---
description: Retrieves the number of discontiguous fragments for the function at the specified virtual address (VA).
title: "IDiaStackWalkHelper::getNumberOfFunctionFragmentsVA"
ms.date: "11/04/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkHelper::getNumberOfFunctionFragmentsVA method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaStackWalkHelper::getNumberOfFunctionFragmentsVA

Retrieves the number of discontiguous fragments for the function at the specified virtual address (VA).

## Syntax

```C++
HRESULT getNumberOfFunctionFragmentsVA(
    ULONGLONG vaFunc,
    DWORD cbFunc,
    DWORD *pNumFragments
);
```

### Parameters

 `vaFunc`

[in] The virtual address of the function.

 `cbFunc`

[in] The total size in bytes of the function (that is, the length of the function).

`pNumFragments`

[out] The number of fragments.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaStackWalkHelper`](../../debugger/debug-interface-access/idiastackwalkhelper.md)
- [`IDiaSession::getNumberOfFunctionFragments_VA`](../../debugger/debug-interface-access/idiasession-getnumberoffunctionfragments_va.md)
