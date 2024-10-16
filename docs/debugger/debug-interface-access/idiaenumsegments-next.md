---
description: Retrieves a specified number of segments in the enumeration sequence.
title: "IDiaEnumSegments::Next"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSegments::Next method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumSegments::Next

Retrieves a specified number of segments in the enumeration sequence.

## Syntax

```c++
HRESULT Next ( 
   ULONG         celt,
   IDiaSegment** rgelt,
   ULONG*        pceltFetched
);
```

#### Parameters

celt

[in] The number of segments in the enumerator to be retrieved.

rgelt

[out] An array that is to be filled in with the desired [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md) objects that represent the segments.

pceltFetched

[out] Returns the number of segments in the fetched enumerator.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if there are no more segments. Otherwise, returns an error code.

## See also

- [IDiaEnumSegments](../../debugger/debug-interface-access/idiaenumsegments.md)
- [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md)
