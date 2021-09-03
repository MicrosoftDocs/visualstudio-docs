---
description: "Retrieves a specified number of source files in the enumeration sequence."
title: "IDiaEnumSourceFiles::Next | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSourceFiles::Next method"
ms.assetid: 83bf6317-ff39-4c5c-8987-cba34e7a6983
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaEnumSourceFiles::Next
Retrieves a specified number of source files in the enumeration sequence.

## Syntax

```C++
HRESULT Next ( 
   ULONG            celt,
   IDiaSourceFile** rgelt,
   ULONG*           pceltFetched
);
```

#### Parameters
 celt

[in] The number of source files in the enumerator to be retrieved.

 rgelt

[out]An array that is to be filled in with the [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md) objects that represent the desired source files.

 pceltFetched

[out] Returns the number of source files in the fetched enumerator.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if there are no more source files. Otherwise, returns an error code.

## See also
- [IDiaEnumSourceFiles](../../debugger/debug-interface-access/idiaenumsourcefiles.md)
- [IDiaSession::findLinesByLinenum](../../debugger/debug-interface-access/idiasession-findlinesbylinenum.md)
- [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md)
