---
title: "IDiaStackFrame::get_systemExceptionHandling | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackFrame::get_systemExceptionHandling"
ms.assetid: c76cf265-dea0-4159-883f-32b50bbef044
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaStackFrame::get_systemExceptionHandling
Retrieves a flag that indicates whether system exception handling is in effect.

## Syntax

```C++
HRESULT get_systemExceptionHandling ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if system exception handling is in effect for this frame; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if the property is not supported. Otherwise, returns an error code.

## Remarks
 System exception handling is also known as structured exception handling. This is not the same thing as C++ exception handling.

 To determine if C++ exception handling is in effect, call the [IDiaStackFrame::get_cplusplusExceptionHandling](../../debugger/debug-interface-access/idiastackframe-get-cplusplusexceptionhandling.md) method.

## See also
- [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)
- [IDiaStackFrame::get_cplusplusExceptionHandling](../../debugger/debug-interface-access/idiastackframe-get-cplusplusexceptionhandling.md)