---
description: Skips a specified number of source link blobs in an enumeration sequence.
title: "IDiaEnumSourceLink::Skip"
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSourceLink::Skip method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaEnumSourceLink::Skip

Skips a specified number of source link blobs in an enumeration sequence.

## Syntax

```c++
HRESULT Skip(
   DWORD cnt
);
```

#### Parameters

 `cnt`

[in] The number of source link blobs in the enumeration sequence to skip.

## Return Value

If successful, returns `S_OK`; otherwise, returns `S_FALSE` if there are no more source link blobs to skip.

## See also

- [`IDiaEnumSourceLink`](../../debugger/debug-interface-access/idiaenumsourcelink.md)
