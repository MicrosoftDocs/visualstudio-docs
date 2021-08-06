---
description: "Retrieves section contributions by means of an index."
title: "IDiaEnumSectionContribs::Item | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSectionContribs::Item method"
ms.assetid: 63a28f23-0ca0-44a7-b11b-ca0206d642a0
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaEnumSectionContribs::Item
Retrieves section contributions by means of an index.

## Syntax

```C++
HRESULT Item ( 
   DWORD                index,
   IDiaSectionContrib** section
);
```

#### Parameters
 index

[in] Index of the [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md) object to be retrieved. The index is in the range 0 to `count`-1, where `count` is returned by the [IDiaEnumSectionContribs::get_Count](../../debugger/debug-interface-access/idiaenumsectioncontribs-get-count.md) method.

 section

[out] Returns an [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md) object representing the desired section contribution.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaEnumSectionContribs::get_Count](../../debugger/debug-interface-access/idiaenumsectioncontribs-get-count.md)
- [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)
