---
title: "IDiaStackWalkHelper::get_registerValue | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkHelper2::get_registerValue method"
ms.assetid: 46ac5eee-73a3-44a1-8635-6c58ba193cb6
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaStackWalkHelper::get_registerValue
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

[in] A value from the [CV_HREG_e Enumeration](../../debugger/debug-interface-access/cv-hreg-e.md) enumeration specifying which register to get the value from.

 `pRetVal`

[out] Returns the current value of the register.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Despite the size of the `pRetVal` parameter, an implementation should store only what the register normally holds. For example, an 8-bit register holds only the lowest 8-bits of the given value. This 8-bit value is expanded to 64-bits when returned from this method.

## See also
- [IDiaStackWalkHelper](../../debugger/debug-interface-access/idiastackwalkhelper.md)
- [CV_HREG_e Enumeration](../../debugger/debug-interface-access/cv-hreg-e.md)