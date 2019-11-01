---
title: "IDiaSymbol::get_hasAlloca | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_hasAlloca method"
ms.assetid: 3b9fb747-670b-4da7-bb70-612f7b911786
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_hasAlloca
Retrieves a flag that specifies whether the function contains a call to `alloca` (which is used to allocate memory on the stack).

## Syntax

```cpp
HRESULT get_hasAlloca(   BOOL *pFlag);
```

#### Parameters
 `pFlag`

[out] Returns `TRUE` if the function contains a call to `alloca`; otherwise, returns `FALSE`.

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