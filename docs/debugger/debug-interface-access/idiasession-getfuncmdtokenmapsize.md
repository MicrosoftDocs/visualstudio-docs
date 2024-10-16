---
description: Retrieves the size, in bytes, of the .NET Native metadata function token map.
title: "IDiaSession::getFuncMDTokenMapSize"
ms.date: "07/04/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::getFuncMDTokenMapSize method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSession::getFuncMDTokenMapSize

Retrieves the size, in bytes, of the .NET Native metadata function token map.

## Syntax

```C++
HRESULT getFuncMDTokenMapSize(
    DWORD *pcb
);
```

#### Parameters

 `pcb`

[out] Returns the size in bytes of the .NET Native metadata function token map.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaSession`](../../debugger/debug-interface-access/idiasession.md)
