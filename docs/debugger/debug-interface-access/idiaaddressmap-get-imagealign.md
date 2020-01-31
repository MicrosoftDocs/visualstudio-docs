---
title: "IDiaAddressMap::get_imageAlign | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaAddressMap::get_imageAlign method"
ms.assetid: f1ba8071-669c-4cf7-9ac0-02f26d99f366
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaAddressMap::get_imageAlign
Retrieves the current image alignment.

## Syntax

```C++
HRESULT get_imageAlign ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns  the image alignment value from the executable.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Images are aligned to specific memory boundaries depending how the image was loaded and created. The alignment is typically on 1, 2, 4, 8, 16, 32, or 64 byte boundaries. The image alignment can be set with a call to the [IDiaAddressMap::put_imageAlign](../../debugger/debug-interface-access/idiaaddressmap-put-imagealign.md) method.

## See also
- [IDiaAddressMap](../../debugger/debug-interface-access/idiaaddressmap.md)
- [IDiaAddressMap::put_imageAlign](../../debugger/debug-interface-access/idiaaddressmap-put-imagealign.md)