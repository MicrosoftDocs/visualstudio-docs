---
description: "IDiaStackWalkFrame::get_registerValue retrieves the value of a register."
title: "IDiaStackWalkFrame::get_registerValue | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkFrame::get_registerValue method"
ms.assetid: ca3c20a9-934a-4b2c-a7f6-7d06e8611ff2
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaStackWalkFrame::get_registerValue
Retrieves the value of a register.

## Syntax

```C++
HRESULT get_registerValue ( 
   DWORD      index,
   ULONGLONG* pRetVal
);
```

#### Parameters
 `index`

[in] A value from the [CV_HREG_e Enumeration](../../debugger/debug-interface-access/cv-hreg-e.md) enumeration specifying the register to get the value for.

 `pRetVal`

[out] Returns the current value of the register.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaStackWalkFrame](../../debugger/debug-interface-access/idiastackwalkframe.md)
- [CV_HREG_e Enumeration](../../debugger/debug-interface-access/cv-hreg-e.md)
