---
description: "Retrieves a flag that indicates whether C++ exception handling is in effect."
title: "IDiaFrameData::get_cplusplusExceptionHandling | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaFrameData::get_cplusplusExceptionHandling method"
ms.assetid: 54ee9cde-ce8e-45f1-809c-6fbad800d850
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaFrameData::get_cplusplusExceptionHandling
Retrieves a flag that indicates whether C++ exception handling is in effect.

## Syntax

```C++
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
 To determine if structured exception handling is in effect (which is very different from C++ exception handling), call the [IDiaFrameData::get_systemExceptionHandling](../../debugger/debug-interface-access/idiaframedata-get-systemexceptionhandling.md) method.

## See also
- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)
- [IDiaFrameData::get_systemExceptionHandling](../../debugger/debug-interface-access/idiaframedata-get-systemexceptionhandling.md)
