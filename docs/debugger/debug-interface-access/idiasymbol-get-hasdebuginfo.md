---
title: "IDiaSymbol::get_hasDebugInfo | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_hasDebugInfo method"
ms.assetid: 84cd2b67-0d83-4589-9ecb-a4bcbeed55f5
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_hasDebugInfo
Retrieves a flag that specifies if the [Compiland](../../debugger/debug-interface-access/compiland.md) contains debugging information.

## Syntax

```C++
HRESULT get_hasDebugInfo(
   BOOL *pFlag
);
```

#### Parameters
 `pFlag`

[out] Returns `TRUE` if the compiland contains debugging information; otherwise, returns `FALSE`.

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