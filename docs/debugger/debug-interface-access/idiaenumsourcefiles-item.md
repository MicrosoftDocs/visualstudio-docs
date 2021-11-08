---
description: "Retrieves a source file by means of an index."
title: "IDiaEnumSourceFiles::Item | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSourceFiles::Item method"
ms.assetid: 3c19d7ed-0232-4b0e-9b10-f33ed9e0c93b
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaEnumSourceFiles::Item
Retrieves a source file by means of an index.

## Syntax

```C++
HRESULT Item ( 
   DWORD            index,
   IDiaSourceFile** sourceFile
);
```

#### Parameters
 index

[in] Index of the [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md) object to be retrieved. The index is in the range 0 to `count`-1, where `count` is returned by the [IDiaEnumSourceFiles::get_Count](../../debugger/debug-interface-access/idiaenumsourcefiles-get-count.md) method.

 sourceFile

[out] Returns an [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md) object representing the desired source file.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaEnumSourceFiles](../../debugger/debug-interface-access/idiaenumsourcefiles.md)
- [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md)
