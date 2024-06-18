---
description: "IDiaFrameData::get_systemExceptionHandling retrieves a flag that indicates whether system exception handling is in effect."
title: "IDiaFrameData::get_systemExceptionHandling"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaFrameData::get_systemExceptionHandling method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaFrameData::get_systemExceptionHandling

Retrieves a flag that indicates whether system exception handling is in effect.

## Syntax

```c++
HRESULT get_systemExceptionHandling ( 
   BOOL* pRetVal
);
```

#### Parameters

pRetVal

[out] Returns `TRUE` if system exception handling is in effect; otherwise, returns `FALSE`.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## Remarks

System exception handling is more commonly known as structured exception handling.

To determine whether C++ exception handling is in effect, call the [IDiaFrameData::get_cplusplusExceptionHandling](../../debugger/debug-interface-access/idiaframedata-get-cplusplusexceptionhandling.md) method.

## See also

- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)
- [IDiaFrameData::get_cplusplusExceptionHandling](../../debugger/debug-interface-access/idiaframedata-get-cplusplusexceptionhandling.md)
