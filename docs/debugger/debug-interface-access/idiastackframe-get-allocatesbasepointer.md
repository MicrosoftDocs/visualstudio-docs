---
description: "IDiaStackFrame::get_allocatesBasePointer retrieves a flag that indicates whether the base pointer is allocated for code in this address range."
title: "IDiaStackFrame::get_allocatesBasePointer"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackFrame::get_allocatesBasePointer"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaStackFrame::get_allocatesBasePointer

Retrieves a flag that indicates whether the base pointer is allocated for code in this address range.

## Syntax

```C++
HRESULT get_allocatesBasePointer ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if a base pointer is allocated for code in this frame; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if the property is not supported. Otherwise, returns an error code.

## See also
- [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)
