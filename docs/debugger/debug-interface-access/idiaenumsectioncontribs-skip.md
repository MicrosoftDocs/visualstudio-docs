---
description: Skips a specified number of section contributions in an enumeration sequence.
title: "IDiaEnumSectionContribs::Skip"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSectionContribs::Skip method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumSectionContribs::Skip

Skips a specified number of section contributions in an enumeration sequence.

## Syntax

```c++
HRESULT Skip( 
   ULONG celt
);
```

#### Parameters

 `celt`

[in] The number of section contributions in the enumeration sequence to skip.

## Return Value

If successful, returns `S_OK`; otherwise, returns `S_FALSE` if there are no more section contributions to skip.

## See also

- [IDiaEnumSectionContribs](../../debugger/debug-interface-access/idiaenumsectioncontribs.md)
