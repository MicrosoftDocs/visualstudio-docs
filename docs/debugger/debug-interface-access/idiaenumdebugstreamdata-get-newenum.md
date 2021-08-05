---
description: "Retrieves the System.Runtime.InteropServices.ComTypes.IEnumVARIANT version of the debug data stream enumerator."
title: "IDiaEnumDebugStreamData::get__NewEnum | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumDebugStreamData::get__NewEnum method"
ms.assetid: 023b3e31-0fc9-478d-88e8-af2ce762f322
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaEnumDebugStreamData::get__NewEnum
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
- [IDiaEnumDebugStreamData](../../debugger/debug-interface-access/idiaenumdebugstreamdata.md)
