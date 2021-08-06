---
description: "Retrieves the value of a specified register as stored in the stack frame."
title: "IDiaStackFrame::get_registerValue | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackFrame::get_registerValue method"
ms.assetid: cbe3d8ac-319a-40ac-bc3e-4eb81b2d7807
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaStackFrame::get_registerValue
Retrieves the value of a specified register as stored in the stack frame.

## Syntax

```C++
HRESULT get_registerValue(
   ULONG      registerIndex,
   ULONGLONG *pRetVal
);
```

#### Parameters
 `registerIndex`

[in] One of the [CV_HREG_e Enumeration](../../debugger/debug-interface-access/cv-hreg-e.md) enumeration values.

 `pRetVal`

[out] Value stored in the register.

## Return Value
 If successful, returns `S_OK`; otherwise, returns error code.

## See also
- [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)
- [CV_HREG_e Enumeration](../../debugger/debug-interface-access/cv-hreg-e.md)
