---
description: Reads the specified number of bytes starting at the specified offset from an executable file.
title: "IDiaReadExeAtOffsetCallback::ReadExecutableAt"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaReadExeAtOffsetCallback::ReadExecutableAt method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaReadExeAtOffsetCallback::ReadExecutableAt

Reads the specified number of bytes starting at the specified offset from an executable file.

## Syntax

```C++
HRESULT ReadExecutableAt ( 
   DWORDLONG fileOffset,
   DWORD     cbData,
   DWORD*    pcbData,
   BYTE      data[]
);
```

#### Parameters
 fileOffset

[in] The offset in the executable file to begin reading.

 cbData

[in] Number of bytes to read.

 pcbData

[out] Returns the number of bytes read.

 data[]

[in, out] An array that is filled in with bytes read from file.

## Remarks
 This method is called by the DIA support code to load data bytes from an executable using an absolute file offset. This method is called in support of the [IDiaDataSource::loadDataForExe](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md) method.

## See also
- [IDiaReadExeAtOffsetCallback](../../debugger/debug-interface-access/idiareadexeatoffsetcallback.md)
- [IDiaDataSource::loadDataForExe](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md)
