---
title: "IDiaStackFrame::get_maxStack | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackFrame::get_maxStack method"
ms.assetid: 6352e972-7105-4d0e-aeba-b8fc16d62dec
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaStackFrame::get_maxStack
Retrieves the maximum number of bytes pushed on the stack in the frame.

## Syntax

```C++
HRESULT get_maxStack ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the maximum number of bytes pushed on the stack.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if the property is not supported. Otherwise, returns an error code.

## See also
- [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)