---
description: "Retrieves a flag that specifies whether the function or thunk layer has been marked as static."
title: "IDiaSymbol::get_isStatic | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_isStatic method"
ms.assetid: 3be5fe1b-46e8-4b07-90d8-4929dbbe7ff7
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_isStatic
Retrieves a flag that specifies whether the function or thunk layer has been marked as static.

## Syntax

```C++
HRESULT get_isStatic(
   BOOL *pFlag
);
```

#### Parameters
 `pFlag`

[out] Returns `TRUE` if the function or thunk layer has been marked as static; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v8.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
