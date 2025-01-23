---
description: Retrieves the System.Runtime.InteropServices.ComTypes.IEnumVARIANT version of the named streams enumerator.
title: "IDiaEnumNamedStreams::get__NewEnum"
ms.date: "11/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumNamedStreams::get__NewEnum method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumNamedStreams::get__NewEnum

Retrieves the <xref:System.Runtime.InteropServices.ComTypes.IEnumVARIANT> version of this enumerator.

## Syntax

```c++
HRESULT get__NewEnum ( 
   [out] IUnknown** pRetVal
);
```

## Parameters

`[out] pRetVal`

Returns the `IUnknown` interface that represents the <xref:System.Runtime.InteropServices.ComTypes.IEnumVARIANT> version of this enumerator. The returned enumerator is clone of the same state at the time this method is called.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaEnumNamedStreams`](../../debugger/debug-interface-access/idiaenumnamedstreams.md)
