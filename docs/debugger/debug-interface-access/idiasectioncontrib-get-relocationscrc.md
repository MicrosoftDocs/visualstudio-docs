---
description: Retrieves the cyclic redundancy check (CRC) of the relocation information for the section.
title: "IDiaSectionContrib::get_relocationsCrc"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSectionContrib::get_relocationsCrc method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
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
