---
description: Retrieves a specified number of frame data elements in the enumeration sequence.
title: "IDiaEnumFrameData::Next"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumFrameData::Next method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumFrameData::Next

Retrieves a specified number of frame data elements in the enumeration sequence.

## Syntax

```c++
HRESULT Next ( 
   ULONG           celt,
   IDiaFrameData** rgelt,
   ULONG*          pceltFetched
);
```

#### Parameters

celt

[in] The number of frame data elements in the enumerator to be retrieved.

rgelt

[out] An array of [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md) objects to be filled in with the requested frame data elements.

pceltFetched

[out] Returns the number of frame data elements in the fetched enumerator.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if there are no more records. Otherwise, returns an error code.

## See also

- [IDiaEnumFrameData](../../debugger/debug-interface-access/idiaenumframedata.md)
- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)
