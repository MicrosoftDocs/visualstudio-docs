---
title: "IDiaStackFrame::get_functionStart | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackFrame::get_functionStart"
ms.assetid: e3e6e88b-0594-4d82-9457-480239a2e85a
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaStackFrame::get_functionStart
Retrieves a flag that indicates whether the block contains the entry point of a function.

## Syntax

```C++
HRESULT get_functionStart ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the stack frame contains the entry point of a function; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if the property is not supported. Otherwise, returns an error code.

## See also
- [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)