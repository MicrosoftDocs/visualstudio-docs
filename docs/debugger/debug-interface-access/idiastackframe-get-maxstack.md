---
description: "IDiaStackFrame::get_maxStack retrieves the maximum number of bytes pushed on the stack in the frame."
title: "IDiaStackFrame::get_maxStack"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackFrame::get_maxStack method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
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
