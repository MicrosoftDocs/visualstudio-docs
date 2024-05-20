---
description: Retrieves the number records in the debug data stream.
title: "IDiaEnumDebugStreamData::get_Count"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumDebugStreamData::get_Count method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumDebugStreamData::get_Count

Retrieves the number records in the debug data stream.

## Syntax

```c++
HRESULT get_Count ( 
   LONG* pRetVal
);
```

#### Parameters

pRetVal
- [out, retval] Returns the number of records.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [IDiaEnumDebugStreamData](../../debugger/debug-interface-access/idiaenumdebugstreamdata.md)
- [IDiaEnumDebugStreamData::Item](../../debugger/debug-interface-access/idiaenumdebugstreamdata-item.md)
