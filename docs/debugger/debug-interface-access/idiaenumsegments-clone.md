---
title: "IDiaEnumSegments::Clone | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSegments::Clone method"
ms.assetid: 93deaac6-72ab-4408-ba14-66174a618757
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaEnumSegments::Clone
Creates an enumerator that contains the same enumeration state as the current enumerator.

## Syntax

```C++
HRESULT Clone ( 
   IDiaEnumSegments** ppenum
);
```

#### Parameters
 ppenum

[out] Returns an [IDiaEnumSegments](../../debugger/debug-interface-access/idiaenumsegments.md) object that contains a duplicate of the enumerator. The segments are not duplicated, only the enumerator.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaEnumSegments](../../debugger/debug-interface-access/idiaenumsegments.md)