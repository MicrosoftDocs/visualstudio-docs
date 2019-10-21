---
title: "IDiaSession::getEnumDebugStreams | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::getEnumDebugStreams method"
ms.assetid: d294954b-80e9-476c-b9f0-5ca6fd575f68
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSession::getEnumDebugStreams
Retrieves an enumerated sequence of debug data streams.

## Syntax

```C++
HRESULT getEnumDebugStreams ( 
   IDiaEnumDebugStreams** ppEnumDebugStreams
)
```

#### Parameters
 `ppEnumDebugStreams`

[out] Returns an [IDiaEnumDebugStreams](../../debugger/debug-interface-access/idiaenumdebugstreams.md) object that contains a list of debug streams.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaEnumDebugStreams](../../debugger/debug-interface-access/idiaenumdebugstreams.md)