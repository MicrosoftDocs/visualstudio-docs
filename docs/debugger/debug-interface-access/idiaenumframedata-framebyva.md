---
title: "IDiaEnumFrameData::frameByVA | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumFrameData::frameByVA method"
ms.assetid: 0b1e441b-710a-46d8-8060-bed39071c834
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaEnumFrameData::frameByVA
Returns a frame by virtual address (VA).

## Syntax

```C++
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