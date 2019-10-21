---
title: "IDiaEnumSectionContribs::get__NewEnum | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSectionContribs::get__NewEnum method"
ms.assetid: a16ee92f-3081-416a-98f6-ce6bc8288a8b
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaEnumSectionContribs::get__NewEnum
Retrieves the <xref:System.Runtime.InteropServices.ComTypes.IEnumVARIANT> version of this enumerator.

## Syntax

```C++
HRESULT get__NewEnum ( 
   IUnknown** pRetVal
);
```

#### Parameters
 pRetVal

[out] Returns the `IUnknown` interface that represents the <xref:System.Runtime.InteropServices.ComTypes.IEnumVARIANT> version of this enumerator.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaEnumSectionContribs](../../debugger/debug-interface-access/idiaenumsectioncontribs.md)