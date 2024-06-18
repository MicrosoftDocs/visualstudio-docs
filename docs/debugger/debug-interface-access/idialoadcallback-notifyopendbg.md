---
description: Called when a candidate .dbg file has been opened.
title: "IDiaLoadCallback::NotifyOpenDBG"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLoadCallback::NotifyOpenDBG method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaLoadCallback::NotifyOpenDBG

Called when a candidate .dbg file has been opened.

## Syntax

```c++
HRESULT NotifyOpenDBG ( 
   LPCOLESTR dbgPath,
   HRESULT   resultCode
);
```

#### Parameters

 `dbgPath`

[in] The full path of the .dbg file.

 `resultCode`

[in] Code that indicates the success (`S_OK`) or failure of the load as applied to this file.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code. The return code is typically ignored.

## See also

- [IDiaLoadCallback2](../../debugger/debug-interface-access/idialoadcallback2.md)
