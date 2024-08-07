---
description: Retrieves the next source link blob and advances the enumeration. Method of IDiaEnumSourceLink2.
title: "IDiaEnumSourceLink2::Next2"
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSourceLink2::Next2 method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaEnumSourceLink2::Next2

Retrieves the next source link blob and advances the enumeration.

## Syntax

```c++
HRESULT Next(
    ULONGLONG cb,
    ULONGLONG* pcb,
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

If successful, returns `S_OK`. If the end of the enumeration has been reached, returns `S_FALSE`. Otherwise, returns an error code. Note that this function does **not** return an error code if `pb` is too small to return the entire source link blob, it merely silently truncates the blob. The caller should always ensure the buffer is big enough and `cb` specifies the correct size of the buffer. Call the [`IDiaEnumSourceLink2::SizeOfNext2`](../../debugger/debug-interface-access/idiaenumsourcelink2-sizeofnext2.md) method to get the needed buffer size.

## See also

- [`IDiaEnumSourceLink2`](../../debugger/debug-interface-access/idiaenumsourcelink2.md)
- [`IDiaEnumSourceLink2::SizeOfNext2`](../../debugger/debug-interface-access/idiaenumsourcelink-sizeofnext.md)
- [`IDiaEnumSourceLink::Next`](../../debugger/debug-interface-access/idiaenumsourcelink-next.md)
