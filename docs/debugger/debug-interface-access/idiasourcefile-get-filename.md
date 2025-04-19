---
description: Retrieves the source file name.
title: "IDiaSourceFile::get_fileName"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSourceFile::get_fileName method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSourceFile::get_fileName

Retrieves the source file name.

## Syntax

```C++
HRESULT get_fileName ( 
   BSTR* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the source file name.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md)
