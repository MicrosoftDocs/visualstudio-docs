---
title: "IDiaEnumSectionContribs::Clone | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSectionContribs::Clone method"
ms.assetid: 81d3f3a7-3684-4e5c-b028-29b268684a2c
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaEnumSectionContribs::Clone
Creates an enumerator that contains the same enumeration state as the current enumerator.

## Syntax

```C++
HRESULT Clone( 
   IDiaEnumSectionContrib** ppenum
);
```

#### Parameters
 ppenum

[out] Returns an [IDiaEnumSectionContribs](../../debugger/debug-interface-access/idiaenumsectioncontribs.md) object that contains a duplicate of the enumerator. The section contributions are not duplicated, only the enumerator.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaEnumSectionContribs](../../debugger/debug-interface-access/idiaenumsectioncontribs.md)