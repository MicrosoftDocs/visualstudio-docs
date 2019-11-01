---
title: "IDiaSymbol::get_container | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_container method"
ms.assetid: 24e832eb-80b3-484c-a41b-11477ec9de99
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_container
This function retrieves a pointer to a symbol representing the parent/container of this symbol.

## Syntax

```C++
HRESULT get_container(
   IDiaSymbol **pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns a pointer to an `IDiaSymbol` containing information about the container of this symbol.

## Return Value
 If successful, returns S_OK; otherwise, returns S_FALSE or an error code.

> [!NOTE]
> A return value of S_FALSE means that the property is not available for the symbol.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v8.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)