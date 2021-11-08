---
description: "Retrieves a flag that indicates whether the section cannot be cached."
title: "IDiaSectionContrib::get_notCached | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSectionContrib::get_notCached method"
ms.assetid: 5408ea53-f64c-431e-9f62-62819026b038
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSectionContrib::get_notCached
Retrieves a flag that indicates whether the section cannot be cached.

## Syntax

```C++
HRESULT get_notCached ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the section cannot be cached; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)
