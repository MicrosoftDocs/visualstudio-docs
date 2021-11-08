---
description: "Retrieves a flag that specifies whether the function contains any Structured Exception Handling (C/C++)) (for example, _try/__except blocks)."
title: "IDiaSymbol::get_hasSEH | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_hasSEH method"
ms.assetid: 1a709ded-22c8-464c-97be-eba5e464210c
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_hasSEH
Retrieves a flag that specifies whether the function contains any [Structured Exception Handling (C/C++)](/cpp/cpp/structured-exception-handling-c-cpp) (for example, __try/\__except blocks).

## Syntax

```C++
HRESULT get_hasSEH(
   BOOL *pFlag
);
```

#### Parameters
 `pFlag`

[out] Returns `TRUE` if the function has any structured exception handling blocks; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v8.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [Structured Exception Handling (C/C++)](/cpp/cpp/structured-exception-handling-c-cpp)
