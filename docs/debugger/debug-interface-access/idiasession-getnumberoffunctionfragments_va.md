---
description: Retrieves the number of discontiguous fragments for the function at the specified virtual address (VA).
title: "IDiaSession::getNumberOfFunctionFragments_VA"
ms.date: "07/05/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::getNumberOfFunctionFragments_VA method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSession::getNumberOfFunctionFragments_VA

Retrieves the number of discontiguous fragments for the function at the specified virtual address (VA).

## Syntax

```C++
HRESULT getNumberOfFunctionFragments_VA(
    ULONGLONG vaFunc,
    DWORD cbFunc,
    DWORD *pNumFragments
);
```

#### Parameters

 `vaFunc`

[in] The virtual address of the function.

 `cbFunc`

[in] The total size in bytes of the function (that is, the length of the function).

`pNumFragments`

[out] The number of fragments.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaSession`](../../debugger/debug-interface-access/idiasession.md)
- [`IDiaSession::getFunctionFragments_VA`](../../debugger/debug-interface-access/idiasession-getfunctionfragments_va.md)
