---
title: "IDiaSegment::get_virtualAddress | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSegment::get_virtualAddress method"
ms.assetid: 30073dd0-c864-4c4a-8863-80f243419f6c
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSegment::get_virtualAddress
Retrieves the virtual address (VA) of the beginning of the section.

## Syntax

```C++
HRESULT get_virtualAddress ( 
   ULONGLONG* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the VA of the beginning of the section.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md)