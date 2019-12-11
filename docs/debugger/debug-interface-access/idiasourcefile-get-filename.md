---
title: "IDiaSourceFile::get_fileName | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSourceFile::get_fileName method"
ms.assetid: a5cb8927-23c6-469e-8f78-f2787d85dba4
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
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