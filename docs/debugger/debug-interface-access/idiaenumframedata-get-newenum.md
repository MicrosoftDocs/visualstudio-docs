---
description: "Retrieves the System.Runtime.InteropServices.ComTypes.IEnumVARIANT version of the frame data enumerator."
title: "IDiaEnumFrameData::get__NewEnum | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumFrameData::get__NewEnum method"
ms.assetid: f5fe0279-0549-4af5-8f89-bcb535fc5809
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaEnumFrameData::get__NewEnum
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
- [IDiaEnumFrameData](../../debugger/debug-interface-access/idiaenumframedata.md)
