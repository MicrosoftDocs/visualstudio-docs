---
title: "IDiaEnumSegments::Item | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSegments::Item method"
ms.assetid: ee44dd55-39a0-4b7b-97ff-2e1226eeb2bd
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaEnumSegments::Item
Retrieves a segment by means of an index.

## Syntax

```C++
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