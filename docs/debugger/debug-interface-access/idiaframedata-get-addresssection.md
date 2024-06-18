---
description: Retrieves the section part of the code address for the frame.
title: "IDiaFrameData::get_addressSection"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaFrameData::get_addressSection method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaFrameData::get_addressSection

Retrieves the section part of the code address for the frame.

## Syntax

```c++
HRESULT get_addressSection ( 
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the section part of the code address for the frame.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also

- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)
