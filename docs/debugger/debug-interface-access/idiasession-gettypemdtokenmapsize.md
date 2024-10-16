---
description: Retrieves the size, in bytes, of the .NET Native metadata type token map.
title: "IDiaSession::getTypeMDTokenMapSize"
ms.date: "07/04/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::getTypeMDTokenMapSize method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSession::getTypeMDTokenMapSize

Retrieves the size, in bytes, of the .NET Native metadata type token map.

## Syntax

```C++
HRESULT getTypeMDTokenMapSize(
    DWORD *pcb
);
```

#### Parameters

 `pcb`

[out] Returns the size in bytes of the .NET Native metadata type token map.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaSession`](../../debugger/debug-interface-access/idiasession.md)
