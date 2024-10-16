---
description: "IDiaStackWalkHelper::put_registerValue sets the value of a register."
title: "IDiaStackWalkHelper::put_registerValue"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkHelper2::put_registerValue method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaStackWalkHelper::put_registerValue

Sets the value of a register.

## Syntax

```C++
HRESULT put_registerValue ( 
   DWORD     index,
   ULONGLONG NewVal
);
```

#### Parameters
 `index`

[in] A value from the [CV_HREG_e Enumeration](../../debugger/debug-interface-access/cv-hreg-e.md) enumeration specifying the register to write to.

 `NewVal`

[in] The new register value.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Despite the size of the value, an implementation should store only what the register normally holds. For example, an 8-bit register would hold only the lowest 8-bits of the given value.

## See also
- [IDiaStackWalkHelper](../../debugger/debug-interface-access/idiastackwalkhelper.md)
- [CV_HREG_e Enumeration](../../debugger/debug-interface-access/cv-hreg-e.md)
