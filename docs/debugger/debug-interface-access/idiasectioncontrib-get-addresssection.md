---
description: Retrieves the section part of the contribution's address.
title: "IDiaSectionContrib::get_addressSection"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSectionContrib::get_addressSection method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSectionContrib::get_addressSection

Retrieves the section part of the contribution's address.

## Syntax

```C++
HRESULT get_addressSection ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the section part of the contribution's address.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)
