---
title: "IDiaSectionContrib::get_comdat | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSectionContrib::get_comdat method"
ms.assetid: 8bd9be8d-59ee-4698-b055-daba354b8dcc
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSectionContrib::get_comdat
Retrieves a flag that indicates whether the section is a COMDAT record.

## Syntax

```C++
HRESULT get_comdat ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the section is a COMDAT record; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## Remarks
 A COMDAT record is a Common Object File Format (COFF) record that makes packaged functions visible to the linker.

## See also
- [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)