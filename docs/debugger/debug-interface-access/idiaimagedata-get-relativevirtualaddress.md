---
title: "IDiaImageData::get_relativeVirtualAddress | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaImageData::get_relativeVirtualAddress method"
ms.assetid: e6d6deee-dc12-4b38-af15-f917b2d4368e
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaImageData::get_relativeVirtualAddress
Retrieves the location in virtual memory of the module relative to the application.

## Syntax

```C++
HRESULT get_relativeVirtualAddress ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the relative virtual memory offset of the module.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaImageData](../../debugger/debug-interface-access/idiaimagedata.md)