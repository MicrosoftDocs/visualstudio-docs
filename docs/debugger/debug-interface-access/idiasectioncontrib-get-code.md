---
title: "IDiaSectionContrib::get_code | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSectionContrib::get_code method"
ms.assetid: f9ccf7a6-46e7-4a1d-9d5c-97272e17bbbb
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSectionContrib::get_code
Retrieves a flag that indicates whether the section contains executable code.

## Syntax

```C++
HRESULT get_code ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the section contains executable code; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)