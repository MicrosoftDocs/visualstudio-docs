---
description: Retrieves the current image alignment.
title: "IDiaAddressMap::get_imageAlign"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaAddressMap::get_imageAlign method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaAddressMap::get_imageAlign

Retrieves the current image alignment.

## Syntax

```c++
HRESULT get_imageAlign ( 
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the image alignment value from the executable.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks

Images are aligned to specific memory boundaries depending how the image was loaded and created. The alignment is typically on 1, 2, 4, 8, 16, 32, or 64 byte boundaries. The image alignment can be set with a call to the [IDiaAddressMap::put_imageAlign](../../debugger/debug-interface-access/idiaaddressmap-put-imagealign.md) method.

## See also

- [IDiaAddressMap](../../debugger/debug-interface-access/idiaaddressmap.md)
- [IDiaAddressMap::put_imageAlign](../../debugger/debug-interface-access/idiaaddressmap-put-imagealign.md)
