---
title: "IDiaSegment::get_frame | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSegment::get_frame method"
ms.assetid: 9fece9c7-064a-4d6b-9cef-fc387f322205
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSegment::get_frame
Retrieves the segment number.

## Syntax

```C++
HRESULT get_frame ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the segment number.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md)