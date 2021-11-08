---
description: "Retrieves the number of debug streams."
title: "IDiaEnumDebugStreams::get_Count | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumDebugStreams::get_Count method"
ms.assetid: 5c13fa9a-b35e-47b0-806f-1f53bfe1ba89
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaEnumDebugStreams::get_Count
Retrieves the number of debug streams.

## Syntax

```C++
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
