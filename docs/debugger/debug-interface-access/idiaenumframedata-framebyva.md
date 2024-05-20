---
description: Returns a frame by virtual address (VA).
title: "IDiaEnumFrameData::frameByVA"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumFrameData::frameByVA method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumFrameData::frameByVA

Returns a frame by virtual address (VA).

## Syntax

```c++
HRESULT frameByVA( 
   ULONGLONG       virtualAddress,
   IDiaFrameData** frame
);
```

#### Parameters

virtualAddress

[in] VA of the frame of interest.

frame

[out] Returns an [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md) object that represents the frame that contains the address provided.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if no frame data matches the specified address. Otherwise, returns an error code.

## See also

- [IDiaEnumFrameData](../../debugger/debug-interface-access/idiaenumframedata.md)
- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)
