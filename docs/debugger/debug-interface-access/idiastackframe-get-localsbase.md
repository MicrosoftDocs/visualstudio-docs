---
title: "IDiaStackFrame::get_localsBase | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackFrame::get_localsBase method"
ms.assetid: eb0bd73e-d92d-468e-a0b1-fbc279919f54
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaStackFrame::get_localsBase
Retrieves the base address of the local variables for the frame.

## Syntax

```C++
HRESULT get_localsBase ( 
   ULONGLONG* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the base address of the local variables.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if the property is not supported. Otherwise, returns an error code.

## See also
- [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)