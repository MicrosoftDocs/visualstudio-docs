---
title: "IDiaStackFrame::get_size | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackFrame::get_size method"
ms.assetid: 71e2f5ab-4aa8-4922-aa8a-b7db97ee143c
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
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