---
description: "IDiaStackFrame::get_lengthProlog retrieves the number of bytes of prologue code in the block."
title: "IDiaStackFrame::get_lengthProlog"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackFrame::get_lengthProlog method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaStackFrame::get_lengthProlog

Retrieves the number of bytes of prologue code in the block.

## Syntax

```C++
HRESULT get_lengthProlog ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the number of bytes of prologue code.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if the property is not supported. Otherwise, returns an error code.

## See also
- [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)
