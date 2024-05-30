---
description: Retrieves the System.Runtime.InteropServices.ComTypes.IEnumVARIANT version of the section contributions enumerator.
title: "IDiaEnumSectionContribs::get__NewEnum"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSectionContribs::get__NewEnum method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumSectionContribs::get__NewEnum

Retrieves the <xref:System.Runtime.InteropServices.ComTypes.IEnumVARIANT> version of this enumerator.

## Syntax

```c++
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
