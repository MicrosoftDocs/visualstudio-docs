---
description: "IDiaStackFrame::get_lengthSavedRegisters retrieves the number of bytes of saved registers pushed on the stack."
title: "IDiaStackFrame::get_lengthSavedRegisters"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackFrame::get_lengthSavedRegisters method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaStackFrame::get_lengthSavedRegisters

Retrieves the number of bytes of saved registers pushed on the stack.

## Syntax

```C++
HRESULT get_lengthSavedRegisters ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the number of bytes of saved registers.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if the property is not supported. Otherwise, returns an error code.

## See also
- [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)
