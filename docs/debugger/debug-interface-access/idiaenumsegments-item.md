---
description: Retrieves a segment by means of an index.
title: "IDiaEnumSegments::Item"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSegments::Item method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumSegments::Item

Retrieves a segment by means of an index.

## Syntax

```c++
HRESULT Item ( 
   DWORD         index,
   IDiaSegment** segment
);
```

#### Parameters

index

[in] Index of the [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md) object to be retrieved. The index is in the range 0 to `count`-1, where `count` is returned by the [IDiaEnumSegments::get_Count](../../debugger/debug-interface-access/idiaenumsegments-get-count.md) method.

segment

[out] Returns an [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md) object representing the desired segment.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [IDiaEnumSegments](../../debugger/debug-interface-access/idiaenumsegments.md)
- [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md)
