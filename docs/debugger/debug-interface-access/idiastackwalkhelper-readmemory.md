---
description: "Reads a block of data from the executable's image in memory."
title: "IDiaStackWalkHelper::readMemory | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkHelper2::readMemory method"
ms.assetid: e1eb90aa-49b7-476c-9e70-7e8f08994cbe
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaStackWalkHelper::readMemory
Reads a block of data from the executable's image in memory.

## Syntax

```C++
HRESULT readMemory( 
   enum MemoryTypeEnum type,
   ULONGLONG           va,
   DWORD               cbData,
   DWORD*              pcbData,
   BYTE*               pbData
);
```

#### Parameters
 `type`

[in] A value from the [MemoryTypeEnum Enumeration](../../debugger/debug-interface-access/memorytypeenum.md) enumeration specifying the type of memory to read.

 va

[in] Virtual address in the image from which to begin reading.

 `cbData`

[in] The size of the data buffer in bytes.

 `pcbData`

[out] Returns the number of bytes actually read. If `pbData` is `NULL`, then this is the total number of bytes of data available.

 `pbData`

[in, out] A buffer that is filled in with the memory read.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaStackWalkHelper](../../debugger/debug-interface-access/idiastackwalkhelper.md)
- [MemoryTypeEnum Enumeration](../../debugger/debug-interface-access/memorytypeenum.md)
