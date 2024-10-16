---
description: Reads the specified number of bytes starting at the specified relative virtual address (RVA) from the executable file.
title: "IDiaReadExeAtRVACallback::ReadExecutableAtRVA"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaReadExeAtRVACallback::ReadExecutableAtRVA method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaReadExeAtRVACallback::ReadExecutableAtRVA

Reads the specified number of bytes starting at the specified relative virtual address (RVA) from the executable file.

## Syntax

```C++
HRESULT ReadExecutableAtRVA ( 
   DWORD  relativeVirtualAddress,
   DWORD  cbData,
   DWORD* pcbData,
   BYTE   data[]
);
```

#### Parameters
 `relativeVirtualAddress`

[in] The RVA in the executable file to begin reading.

 `cbData`

[in] Number of bytes to read.

 `pcbData`

[out] Returns the number of bytes read.

 `data[]`

[in, out] An array that is filled in with bytes read from the file.

## Remarks
 This method is called by the DIA support code to load data bytes from an executable using a relative virtual address. This method is called in support of the [IDiaDataSource::loadDataForExe](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md) method.

## See also
- [IDiaReadExeAtRVACallback](../../debugger/debug-interface-access/idiareadexeatrvacallback.md)
- [IDiaDataSource::loadDataForExe](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md)
