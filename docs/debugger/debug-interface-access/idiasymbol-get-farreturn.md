---
description: "Retrieves a flag that specifies whether the function contains a far return."
title: "IDiaSymbol::get_farReturn | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_farReturn method"
ms.assetid: 141df0e9-f4d9-4330-a043-5d9ea865257f
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_farReturn
Retrieves a flag that specifies whether the function contains a far return.

## Syntax

```C++
HRESULT get_farReturn(
   BOOL *pFlag
);
```

#### Parameters
 `pFlag`

[in] Returns `TRUE` if the function uses a far return, otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v8.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
