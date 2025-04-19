---
description: Retrieves an enumerated sequence of debug data streams.
title: "IDiaSession::getEnumDebugStreams"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::getEnumDebugStreams method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
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
