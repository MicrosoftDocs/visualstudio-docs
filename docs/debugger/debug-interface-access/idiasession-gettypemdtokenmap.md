---
description: "Retrieves the contents of the .NET Native metadata type token map."
title: "IDiaSession::getTypeMDTokenMap"
ms.date: "07/04/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::getTypeMDTokenMap method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# `IDiaSession::getTypeMDTokenMap`

Retrieves the contents of the .NET Native metadata type token map.

## Syntax

```C++
HRESULT getTypeMDTokenMap(
    DWORD cb,
    DWORD *pcb,
    BYTE *pb
);
```

#### Parameters

 `cb`

[in] The size in bytes of the buffer pointed to by `pb` for receiving the .NET Native metadata type token map.

 `pcb`

[out] Returns the size in bytes of the .NET Native metadata type token map (i.e. the number of bytes written into `pb`).

 `pb`

[out] Buffer to receive the contents of the .NET Native metadata type token map. This must be at least `cb` bytes in size. 

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaSession`](../../debugger/debug-interface-access/idiasession.md)
