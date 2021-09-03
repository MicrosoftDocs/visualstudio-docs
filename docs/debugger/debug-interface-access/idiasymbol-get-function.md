---
description: "Retrieves a flag that specifies whether the public symbol refers to a function."
title: "IDiaSymbol::get_function | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_function method"
ms.assetid: 48b3a318-3211-410f-8570-c02ee210f0a5
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_function
Retrieves a flag that specifies whether the public symbol refers to a function.

## Syntax

```C++
HRESULT get_function ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns a `TRUE` if the symbol refers to a function; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v7.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
