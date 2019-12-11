---
title: "IDiaSymbol::get_isAggregated | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_isAggregated method"
ms.assetid: 24d280ef-6ea3-4958-9418-4ad3ca7c67c1
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_isAggregated
Retrieves a flag that specifies whether the data symbol is part of an aggregate or collection of symbols; the compiler will treat aggregated symbols as separate entities, but they are really part of a single larger symbol.

## Syntax

```C++
HRESULT get_isAggregated(
   BOOL *pFlag
);
```

#### Parameters
 `pFlag`

[out] Returns `TRUE` if the data is part of an aggregation of symbols split from a parent symbol; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 The [IDiaSymbol::get_isSplitted](../../debugger/debug-interface-access/idiasymbol-get-issplitted.md) method is `TRUE` for the symbol that is the parent of the aggregated symbols.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v8.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [IDiaSymbol::get_isSplitted](../../debugger/debug-interface-access/idiasymbol-get-issplitted.md)