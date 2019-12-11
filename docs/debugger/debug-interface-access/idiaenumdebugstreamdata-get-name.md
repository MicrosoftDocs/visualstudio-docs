---
title: "IDiaEnumDebugStreamData::get_name | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumDebugStreamData::get_Name method"
ms.assetid: e6cf2bed-ee2b-4122-886d-c20d93df7ff2
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaEnumDebugStreamData::get_name
Retrieves the name of a debug data stream.

## Syntax

```C++
HRESULT get_Name ( 
   BSTR * pRetVal
)
```

#### Parameters
 pRetVal

[out] Returns the name of a debug data stream.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaEnumDebugStreamData](../../debugger/debug-interface-access/idiaenumdebugstreamdata.md)