---
description: "IDiaStackFrame::get_lengthLocals retrieves the number of bytes of local variables pushed on the stack."
title: "IDiaStackFrame::get_lengthLocals"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackFrame::get_lengthLocals method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaStackFrame::get_lengthLocals

Retrieves the number of bytes of local variables pushed on the stack.

## Syntax

```C++
HRESULT get_lengthLocals ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the number of bytes of local variables.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if the property is not supported. Otherwise, returns an error code.

## See also
- [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)
