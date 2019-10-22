---
title: "IDiaSegment::get_relativeVirtualAddress | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSegment::get_relativeVirtualAddress method"
ms.assetid: b6a573a1-3671-4c1c-a5c2-2ab8f07fd510
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSegment::get_relativeVirtualAddress
Retrieves the relative virtual address (RVA) of the beginning of the section.

## Syntax

```C++
HRESULT get_relativeVirtualAddress ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the RVA of the beginning of the section.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md)