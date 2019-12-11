---
title: "IDiaSymbol::get_isNaked | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_isNaked method"
ms.assetid: b16629dc-8e17-476b-9c7b-58e7277c61ed
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_isNaked
Retrieves a flag that specifies whether the function has the [naked](/cpp/cpp/naked-cpp) attribute (that is, the function has no prolog or epilog code added by the compiler).

## Syntax

```C++
HRESULT get_isNaked(
   BOOL *pFlag
);
```

#### Parameters
 `pFlag`

[out] Returns `TRUE` if the function has the `naked` attribute; otherwise, returns `FALSE`.

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
- [Naked Function Calls](/cpp/cpp/naked-function-calls)