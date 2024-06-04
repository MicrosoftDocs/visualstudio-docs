---
description: Retrieves a frame data interface for the enclosing function.
title: "IDiaFrameData::get_functionParent"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaFrameData::get_functionParent method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaFrameData::get_functionParent

Retrieves a frame data interface for the enclosing function.

## Syntax

```c++
HRESULT get_functionParent ( 
   IDiaFrameData** pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns an [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md) object for the enclosing function.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)
