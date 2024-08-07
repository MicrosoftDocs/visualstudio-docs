---
description: Retrieves the System.Runtime.InteropServices.ComTypes.IEnumVARIANT version of the innput assembly file enumerator.
title: "IDiaEnumInputAssemblyFiles::get__NewEnum"
ms.date: "7/2/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumInputAssemblyFiles::get__NewEnum method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumInputAssemblyFiles::get__NewEnum

Retrieves the <xref:System.Runtime.InteropServices.ComTypes.IEnumVARIANT> version of this enumerator.

## Syntax

```c++
HRESULT get__NewEnum ( 
   IUnknown** pRetVal
);
```

#### Parameters

`pRetVal`

- [out, retval] Returns the `IUnknown` interface that represents the <xref:System.Runtime.InteropServices.ComTypes.IEnumVARIANT> version of this enumerator.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaEnumInputAssemblyFiles`](../../debugger/debug-interface-access/idiaenuminputassemblyfiles.md)
