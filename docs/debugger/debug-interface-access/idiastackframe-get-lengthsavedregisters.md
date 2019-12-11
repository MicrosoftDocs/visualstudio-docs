---
title: "IDiaStackFrame::get_lengthSavedRegisters | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackFrame::get_lengthSavedRegisters method"
ms.assetid: b75fad6e-1ef4-44e6-89e3-c31c6fba10b3
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
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