---
description: "Reads memory from image."
title: "IDiaStackWalkFrame::readMemory | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkFrame::readMemory method"
ms.assetid: 7ab0b525-a5a7-4692-acad-e8c00fa9ab9a
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaStackWalkFrame::readMemory
Reads memory from image.

## Syntax

```C++
HRESULT readMemory ( 
   MemoryTypeEnum type,
   ULONGLONG va,
   DWORD     cbData,
   DWORD*    pcbData,
   BYTE      data[]
);
```

#### Parameters
 `type`

[in] One of the [MemoryTypeEnum Enumeration](../../debugger/debug-interface-access/memorytypeenum.md) enumeration values that specifies the kind of memory to access.

 `va`

[in] Virtual address location in image to begin reading.

 `cbData`

[in] Size of the data buffer, in bytes.

 `pcbData`

[out] Returns the number of bytes returned. If `data` is `NULL`, then `pcbData` contains the total number of bytes of data available.

 `data`

[out] A buffer that is to be filled in with data from the specified location.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaStackWalkFrame](../../debugger/debug-interface-access/idiastackwalkframe.md)
