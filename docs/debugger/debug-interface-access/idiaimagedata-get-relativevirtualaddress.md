---
description: Retrieves the location in virtual memory of the module relative to the application.
title: "IDiaImageData::get_relativeVirtualAddress"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaImageData::get_relativeVirtualAddress method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaImageData::get_relativeVirtualAddress

Retrieves the location in virtual memory of the module relative to the application.

## Syntax

```c++
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
