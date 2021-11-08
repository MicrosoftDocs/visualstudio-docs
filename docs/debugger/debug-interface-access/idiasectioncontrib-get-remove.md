---
description: "Retrieves a flag that indicates whether the section is removed before it is made part of the in-memory image."
title: "IDiaSectionContrib::get_remove | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSectionContrib::get_remove method"
ms.assetid: fd30ab7b-022b-4402-a42a-2d38e274c1b1
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSectionContrib::get_remove
Retrieves a flag that indicates whether the section is removed before it is made part of the in-memory image.

## Syntax

```C++
HRESULT get_remove ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the section is not to be added to the in-memory image; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)
