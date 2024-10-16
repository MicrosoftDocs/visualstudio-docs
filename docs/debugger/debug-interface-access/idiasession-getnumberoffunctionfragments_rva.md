---
description: Retrieves the number of discontiguous fragments for the function at the specified relative virtual address (RVA).
title: "IDiaSession::getNumberOfFunctionFragments_RVA"
ms.date: "07/05/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::getNumberOfFunctionFragments_RVA method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSession::getNumberOfFunctionFragments_RVA

Retrieves the number of discontiguous fragments for the function at the specified relative virtual address (RVA).

## Syntax

```C++
HRESULT getNumberOfFunctionFragments_RVA(
    DWORD rvaFunc,
    DWORD cbFunc,
    DWORD *pNumFragments
);
```

#### Parameters

 `rvaFunc`

[in] The relative virtual address of the function.

 `cbFunc`

[in] The total size in bytes of the function (that is, the length of the function).

`pNumFragments`

[out] The number of fragments.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaSession`](../../debugger/debug-interface-access/idiasession.md)
- [`IDiaSession::getFunctionFragments_RVA`](../../debugger/debug-interface-access/idiasession-getfunctionfragments_rva.md)
