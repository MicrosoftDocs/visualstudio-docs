---
description: "Retrieves a flag that indicates whether the segment can be modified."
title: "IDiaSegment::get_write | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSegment::get_write method"
ms.assetid: 5fcda988-6be1-4b2f-8660-b59aa78fc35d
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSegment::get_write
Retrieves a flag that indicates whether the segment can be modified.

## Syntax

```C++
HRESULT get_write ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the segment can be written to; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md)
