---
description: Retrieves the next source link blob and advances the enumeration.
title: "IDiaEnumSourceLink::Next"
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSourceLink::Next method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaEnumSourceLink::Next

Retrieves the next source link blob and advances the enumeration.

## Syntax

```c++
HRESULT Next(
    DWORD cb,
    DWORD* pcb,
    BYTE* pb
);
```

#### Parameters

 `cb`

[in] Specifies the number of bytes in the buffer `pb`. This should never be 0.

 `pcb`

[out, optional] Returns the number of bytes written to the buffer `pb` upon success.

 `pb`

[out] Returns the bytes for next source link blob.

## Return Value

If successful, returns `S_OK`. If the end of the enumeration has been reached, returns `S_FALSE`. Otherwise, returns an error code. Note that this function does **not** return an error code if `pb` is too small to return the entire source link blob, it merely silently truncates the blob. The caller should always ensure the buffer is big enough and `cb` specifies the correct size of the buffer. Call the [`IDiaEnumSourceLink::SizeOfNext`](../../debugger/debug-interface-access/idiaenumsourcelink-sizeofnext.md) method to get the needed buffer size.

## See also

- [`IDiaEnumSourceLink`](../../debugger/debug-interface-access/idiaenumsourcelink.md)
- [`IDiaEnumSourceLink::SizeOfNext`](../../debugger/debug-interface-access/idiaenumsourcelink-sizeofnext.md)
- [`IDiaEnumSourceLink2::Next2`](../../debugger/debug-interface-access/idiaenumsourcelink2-next2.md)
