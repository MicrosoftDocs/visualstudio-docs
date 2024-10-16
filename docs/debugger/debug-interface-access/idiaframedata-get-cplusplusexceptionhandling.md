---
description: Retrieves a flag that indicates whether C++ exception handling is in effect.
title: "IDiaFrameData::get_cplusplusExceptionHandling"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaFrameData::get_cplusplusExceptionHandling method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaFrameData::get_cplusplusExceptionHandling

Retrieves a flag that indicates whether C++ exception handling is in effect.

## Syntax

```c++
HRESULT get_cplusplusExceptionHandling ( 
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` if C++ exception handling is in effect; otherwise, returns `FALSE`.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## Remarks

To determine whether structured exception handling is in effect (which is very different from C++ exception handling), call the [IDiaFrameData::get_systemExceptionHandling](../../debugger/debug-interface-access/idiaframedata-get-systemexceptionhandling.md) method.

## See also

- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)
- [IDiaFrameData::get_systemExceptionHandling](../../debugger/debug-interface-access/idiaframedata-get-systemexceptionhandling.md)
