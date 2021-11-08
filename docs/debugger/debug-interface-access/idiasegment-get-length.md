---
description: "Retrieves the number of bytes in the segment."
title: "IDiaSegment::get_length | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSegment::get_length method"
ms.assetid: 5d92e394-649b-49f2-bce7-12dd9d666d85
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSegment::get_length
Retrieves the number of bytes in the segment.

## Syntax

```C++
HRESULT get_ length ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the number of bytes in the segment.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md)
