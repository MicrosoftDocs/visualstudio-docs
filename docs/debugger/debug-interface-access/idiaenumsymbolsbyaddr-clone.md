---
title: "IDiaEnumSymbolsByAddr::Clone | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSymbolsByAddr::Clone method"
ms.assetid: f4582c69-bc3f-4a26-bcca-b641102b85fe
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaEnumSymbolsByAddr::Clone
Makes a copy of an object.

## Syntax

```C++
HRESULT Clone ( 
   IDiaEnumSymbolsByAddr** ppenum
);
```

#### Parameters
 ppenum

[out] Returns an [IDiaEnumSymbolsByAddr](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr.md) object that contains a duplicate of the enumerator. The symbols are not duplicated, only the enumerator.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaEnumSymbolsByAddr](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr.md)