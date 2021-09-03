---
description: "Retrieves the location in virtual memory of the image."
title: "IDiaImageData::get_virtualAddress | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaImageData::get_virtualAddress method"
ms.assetid: 67ecdc8c-d342-4d0b-b02a-c6b88e22fd02
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaImageData::get_virtualAddress
Retrieves the location in virtual memory of the image.

## Syntax

```C++
HRESULT get_virtualAddress ( 
   ULONGLONG* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the virtual address of the image.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaImageData](../../debugger/debug-interface-access/idiaimagedata.md)
