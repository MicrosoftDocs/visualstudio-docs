---
description: Returns a frame by relative virtual address (RVA).
title: "IDiaEnumFrameData::frameByRVA"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumFrameData::frameByRVA method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumFrameData::frameByRVA

Returns a frame by relative virtual address (RVA).

## Syntax

```c++
HRESULT frameByRVA( 
   DWORD           relativeVirtualAddress,
   IDiaFrameData** frame
);
```

#### Parameters

relativeVirtualAddress

[in] RVA of the frame of interest.

frame

[out] Returns an [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md) object representing the frame that contains the address provided.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if no frame data matches the specified address. Otherwise, returns an error code.

## See also

- [IDiaEnumFrameData](../../debugger/debug-interface-access/idiaenumframedata.md)
- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)
