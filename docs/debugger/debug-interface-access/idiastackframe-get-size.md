---
description: Retrieves the size of the stack frame in bytes.
title: "IDiaStackFrame::get_size"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackFrame::get_size method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaStackFrame::get_size

Retrieves the size of the stack frame in bytes.

## Syntax

```C++
HRESULT get_size ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the size of the stack frame in bytes.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if the property is not supported. Otherwise, returns an error code.

## See also
- [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)
