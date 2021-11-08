---
description: "Retrieves the section number that maps to this segment."
title: "IDiaSegment::get_addressSection | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSegment::get_addressSection method"
ms.assetid: 360b61b1-69b1-4a8b-ba37-97a1d835ac53
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSegment::get_addressSection
Retrieves the section number that maps to this segment.

## Syntax

```C++
HRESULT get_addressSection ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the section number that maps to this segment.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md)
