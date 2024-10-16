---
description: Retrieves the number of frame data elements.
title: "IDiaEnumFrameData::get_Count"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumFrameData::get_Count method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumFrameData::get_Count

Retrieves the number of frame data elements.

## Syntax

```c++
HRESULT get_Count ( 
   LONG* pRetVal
);
```

#### Parameters

pRetVal

[out] Returns the number of frame data elements.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [IDiaEnumFrameData](../../debugger/debug-interface-access/idiaenumframedata.md)
- [IDiaEnumFrameData::Item](../../debugger/debug-interface-access/idiaenumframedata-item.md)
