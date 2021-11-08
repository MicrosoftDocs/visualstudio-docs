---
description: "Retrieves a flag that indicates whether the section can be modified."
title: "IDiaSectionContrib::get_write | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSectionContrib::get_write method"
ms.assetid: 7e75348e-c12c-44ec-b004-e97767580a3f
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSectionContrib::get_write
Retrieves a flag that indicates whether the section can be modified.

## Syntax

```C++
HRESULT get_write ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the section can be written to; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)
