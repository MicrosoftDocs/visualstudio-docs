---
description: Retrieves the checksum type.
title: "IDiaSourceFile::get_checksumType"
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSourceFile::get_checksumType method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# `IDiaSourceFile::get_checksumType`

Retrieves the checksum type.

## Syntax

```C++
HRESULT get_checksumType ( 
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the checksum type as a value from [`CV_SourceChksum_t`](../../debugger/debug-interface-access/cv-sourcechksum-t.md).

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks

 To obtain the actual checksum bytes for the source file, call the [IDiaSourceFile::get_checksum](../../debugger/debug-interface-access/idiasourcefile-get-checksum.md) method.

## See also

- [`IDiaSourceFile`](../../debugger/debug-interface-access/idiasourcefile.md)
- [`IDiaSourceFile::get_checksum`](../../debugger/debug-interface-access/idiasourcefile-get-checksum.md)
- [`CV_SourceChksum_t`](../../debugger/debug-interface-access/cv-sourcechksum-t.md)
