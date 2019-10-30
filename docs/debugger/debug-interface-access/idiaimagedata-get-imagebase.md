---
title: "IDiaImageData::get_imageBase | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaImageData::get_imageBase method"
ms.assetid: 4ba3d9e4-b205-4ee6-a41d-6996972f1f85
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaImageData::get_imageBase
Retrieves the memory location where the image should be based.

## Syntax

```C++
HRESULT get_imageBase ( 
   ULONGLONG* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the suggested image base value.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Due to image base conflicts, an image may be rebased automatically to an unused memory location when it is loaded. This method returns the base hint (suggested memory location) that was stored in the module at compile time.

## See also
- [IDiaImageData](../../debugger/debug-interface-access/idiaimagedata.md)