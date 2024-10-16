---
description: Retrieves the number of debug streams.
title: "IDiaEnumDebugStreams::get_Count"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumDebugStreams::get_Count method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumDebugStreams::get_Count

Retrieves the number of debug streams.

## Syntax

```c++
HRESULT get_Count( 
   LONG* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the number of debug streams available in this enumerator.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [IDiaEnumDebugStreams](../../debugger/debug-interface-access/idiaenumdebugstreams.md)
- [IDiaEnumDebugStreams::Item](../../debugger/debug-interface-access/idiaenumdebugstreams-item.md)
