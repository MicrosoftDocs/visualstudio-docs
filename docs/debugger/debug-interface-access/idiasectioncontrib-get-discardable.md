---
description: "Retrieves a flag that indicates whether the section can be discarded."
title: "IDiaSectionContrib::get_discardable | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSectionContrib::get_discardable method"
ms.assetid: 30ca88d4-3198-4b0f-b30e-2e54b3607fe9
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSectionContrib::get_discardable
Retrieves a flag that indicates whether the section can be discarded.

## Syntax

```C++
HRESULT get_discardable ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the section can be discarded from memory as needed; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)
