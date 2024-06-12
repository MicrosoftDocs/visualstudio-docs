---
description: Skips a specified number of frame data elements in an enumeration sequence.
title: "IDiaEnumFrameData::Skip"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumFrameData::Skip method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumFrameData::Skip

Skips a specified number of frame data elements in an enumeration sequence.

## Syntax

```c++
HRESULT Skip ( 
   ULONG celt
);
```

#### Parameters

celt

[in] The number of frame data elements in the enumeration sequence to skip.

## Return Value

If successful, returns `S_OK`; otherwise, returns `S_FALSE` if there are no more records to skip.

## See also

- [IDiaEnumFrameData](../../debugger/debug-interface-access/idiaenumframedata.md)
