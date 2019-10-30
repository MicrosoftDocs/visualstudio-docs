---
title: "IDiaSymbol::get_callingConvention | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_callingConvention method"
ms.assetid: 355d3877-b6b6-45fd-a1d8-baed428d8f96
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_callingConvention
Returns an indicator of a methods calling convention.

## Syntax

```C++
HRESULT get_callingConvention ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns a value from the [CV_call_e Enumeration](../../debugger/debug-interface-access/cv-call-e.md) enumeration that specifies a method's calling convention.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v7.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [CV_call_e Enumeration](../../debugger/debug-interface-access/cv-call-e.md)