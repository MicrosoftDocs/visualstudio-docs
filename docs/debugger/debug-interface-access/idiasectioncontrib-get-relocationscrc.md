---
title: "IDiaSectionContrib::get_relocationsCrc | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSectionContrib::get_relocationsCrc method"
ms.assetid: 8c29c91a-062d-4566-a9b7-49251036a15a
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSectionContrib::get_relocationsCrc
Retrieves the cyclic redundancy check (CRC) of the relocation information for the section.

## Syntax

```C++
HRESULT get_relocationsCrc ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the CRC of the relocation information for the section.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)