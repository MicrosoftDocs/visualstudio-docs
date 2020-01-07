---
title: "IDiaSymbol::get_editAndContinueEnabled | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_editAndContinueEnabled method"
ms.assetid: cd703c64-9ff8-4654-8493-8cde9309cb22
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_editAndContinueEnabled
Retrieves a flag indicating whether the module was compiled with the [/Z7, /Zi, /ZI (Debug Information Format)](/cpp/build/reference/z7-zi-zi-debug-information-format) compiler switch.

## Syntax

```C++
HRESULT get_editAndContinueEnabled ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if edit-and-continue was enabled at compilation; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v7.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [/Z7, /Zi, /ZI (Debug Information Format)](/cpp/build/reference/z7-zi-zi-debug-information-format)