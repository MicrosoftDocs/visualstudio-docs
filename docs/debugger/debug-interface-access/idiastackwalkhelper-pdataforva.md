---
description: Returns the PDATA data block associated with the virtual address.
title: "IDiaStackWalkHelper::pdataForVA"
ms.date: "11/04/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkHelper::pdataByVA method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaStackWalkHelper::pdataForVA

Returns the PDATA data block associated with the virtual address.

## Syntax

```C++
HRESULT pdataForVA( 
   ULONGLONG  va,
   DWORD      cbData,
   DWORD*     pcbData,
   BYTE*      pbData
);
```

### Parameters

 `[in] va`

Specifies the virtual address of the data to obtain.

 `[in] cbData`

The size of data in bytes to obtain.

 `[out] pcbData`

Returns the actual size of data in bytes that was obtained.

 `[in, out] pbData`

A buffer that is filled in with the requested data. Can't be `NULL`.

## Return Value

 If successful, returns `S_OK`. Returns `S_FALSE` if there's no PDATA for the specified address. Otherwise, return an error code.

## Remarks

 The `.pdata` section of a compiland contains information about exception handling for functions. It appears in the [PE Format](/windows/win32/debug/pe-format) as the "Exception Table" within the "Optional Header Data Directories."

 The caller knows how much data is to be returned so the caller has no need to ask for how much data is available. Therefore, it's acceptable for an implementation of this method to return an error if the `pbData` parameter is `NULL`.

## See also

- [`IDiaStackWalkHelper`](../../debugger/debug-interface-access/idiastackwalkhelper.md)
- [PE Format - The `.pdata` Section](/windows/win32/debug/pe-format#the-pdata-section)
