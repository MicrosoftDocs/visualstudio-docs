---
description: Retrieves the number of section contributions.
title: "IDiaEnumSectionContribs::get_Count"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSectionContribs::get_Count interface"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumSectionContribs::get_Count

Retrieves the number of section contributions.

## Syntax

```c++
HRESULT get_Count ( 
   LONG* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the number of section contributions.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [IDiaEnumSectionContribs](../../debugger/debug-interface-access/idiaenumsectioncontribs.md)
- [IDiaEnumSectionContribs::Item](../../debugger/debug-interface-access/idiaenumsectioncontribs-item.md)
