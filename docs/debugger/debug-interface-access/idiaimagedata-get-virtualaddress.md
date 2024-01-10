---
description: "Retrieves the location in virtual memory of the image."
title: "IDiaImageData::get_virtualAddress"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaImageData::get_virtualAddress method"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.subservice: vs-ide-debug
---
# IDiaImageData::get_virtualAddress

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
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
