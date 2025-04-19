---
description: Retrieves the number of source link blobs.
title: "IDiaEnumSourceLink::Count"
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSourceLink::Count method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaEnumSourceLink::Count

Retrieves the number of source link blobs.

## Syntax

```c++
HRESULT Count(
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the number of source link blobs.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaEnumSourceLink`](../../debugger/debug-interface-access/idiaenumsourcelink.md)
