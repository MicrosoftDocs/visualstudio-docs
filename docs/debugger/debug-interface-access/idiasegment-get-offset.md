---
title: "IDiaSegment::get_offset | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSegment::get_offset method"
ms.assetid: 97415ac6-b072-4e3c-9dd3-73087ae605fc
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSegment::get_offset
Retrieves the offset, in segments, where the section begins.

## Syntax

```C++
HRESULT get_offset ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the offset, in segments, where the section begins.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md)