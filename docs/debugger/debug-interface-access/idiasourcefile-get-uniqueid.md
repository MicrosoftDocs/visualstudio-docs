---
description: Retrieves a simple integer key value that is unique for this image.
title: "IDiaSourceFile::get_uniqueId"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSourceFile::get_uniqueId method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSourceFile::get_uniqueId

Retrieves a simple integer key value that is unique for this image.

## Syntax

```C++
HRESULT get_uniqueId ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns a simple integer key value that is unique for this image.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Comparing keys rather than strings can accelerate line number processing.

## See also
- [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md)
