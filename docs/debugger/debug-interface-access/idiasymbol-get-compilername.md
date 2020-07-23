---
title: "IDiaSymbol::get_compilerName | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_compilerName method"
ms.assetid: 66eaaf72-68d4-40ee-b132-97bea9fe395c
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_compilerName
Returns the name of the compiler used to generate the [Compiland](../../debugger/debug-interface-access/compiland.md).

## Syntax

```C++
HRESULT get_compilerName (
   BSTR *pName
);
```

#### Parameters
 `pName`
 Pointer to a BSTR that will contain the Unicode name of the compiler.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v8.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)