---
title: "IDiaSectionContrib::get_informational | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSectionContrib::get_informational method"
ms.assetid: 5351e89f-7db1-4f8e-9e57-2dd1c74002e0
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSectionContrib::get_informational
Retrieves a flag indicating whether a section contains comments or similar information.

## Syntax

```C++
HRESULT get_informational(
   BOOL* pRetVal
};
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the section contains comments or other information; otherwise returns `FALSE`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## Remarks
 Typically the .directive section contains information.

## See also
- [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)