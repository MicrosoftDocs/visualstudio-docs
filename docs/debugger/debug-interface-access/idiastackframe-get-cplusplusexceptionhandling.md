---
title: "IDiaStackFrame::get_cplusplusExceptionHandling | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackFrame::get_cplusplusExceptionHandling method"
ms.assetid: f2631820-c986-40ca-b61e-230d7a9c426c
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaStackFrame::get_cplusplusExceptionHandling
Retrieves a flag that indicates if C++ exception handling is in effect.

## Syntax

```C++
HRESULT get_cplusplusExceptionHandling ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if C++ exception handling is in effect for this frame; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if the property is not supported. Otherwise, returns an error code.

## Remarks
 C++ exception handling is not the same as structured or system exception handling.

 To determine if structured exception handling is in effect, call the [IDiaStackFrame::get_systemExceptionHandling](../../debugger/debug-interface-access/idiastackframe-get-systemexceptionhandling.md) method.

## See also
- [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)
- [IDiaStackFrame::get_systemExceptionHandling](../../debugger/debug-interface-access/idiastackframe-get-systemexceptionhandling.md)