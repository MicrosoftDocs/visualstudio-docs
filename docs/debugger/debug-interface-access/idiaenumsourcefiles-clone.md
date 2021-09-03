---
description: "Creates an enumerator that contains the same enumeration state as the current source files enumerator."
title: "IDiaEnumSourceFiles::Clone | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSourceFiles::Clone method"
ms.assetid: 87a9a9b6-3927-4131-927c-ad95f8f098b9
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaEnumSourceFiles::Clone
Creates an enumerator that contains the same enumeration state as the current enumerator.

## Syntax

```C++
HRESULT Clone ( 
   IDiaEnumSourceFiles** ppenum
);
```

#### Parameters
 ppenum

[out] Returns an [IDiaEnumSourceFiles](../../debugger/debug-interface-access/idiaenumsourcefiles.md) object that contains a duplicate of the enumerator. The source files are not duplicated, only the enumerator.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaEnumSourceFiles](../../debugger/debug-interface-access/idiaenumsourcefiles.md)
