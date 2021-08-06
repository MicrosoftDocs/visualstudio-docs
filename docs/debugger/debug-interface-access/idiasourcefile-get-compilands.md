---
description: "Retrieves an enumerator of compilands that have line numbers referencing this file."
title: "IDiaSourceFile::get_compilands | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSourceFile::get_compilands method"
ms.assetid: 57deb50a-9c22-43ea-a80c-eab205997bc4
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSourceFile::get_compilands
Retrieves an enumerator of compilands that have line numbers referencing this file.

## Syntax

```C++
HRESULT get_compilands ( 
   IDiaEnumSymbols** ppRetVal
);
```

#### Parameters
 `ppRetVal`

[out] Returns an [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md) object that contains a list of all compilands that have line numbers referencing this file.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md)
- [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md)
