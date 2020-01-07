---
title: "IDiaEnumSectionContribs::get_Count | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSectionContribs::get_Count interface"
ms.assetid: 94f11de3-9393-4a5c-9814-2e6bdb597f70
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaEnumSectionContribs::get_Count
Retrieves the number of section contributions.

## Syntax

```C++
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