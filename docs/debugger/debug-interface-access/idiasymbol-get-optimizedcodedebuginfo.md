---
title: "IDiaSymbol::get_optimizedCodeDebugInfo | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_optimizedCodeDebugInfo method"
ms.assetid: 57ef4170-37a9-46b0-8217-c1a674725113
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_optimizedCodeDebugInfo
Retrieves a flag that indicates whether the function contains debug information that is specific for optimized code.

## Syntax

```C++
HRESULT get_optimizedCodeDebugInfo(
   BOOL *pFlag
);
```

#### Parameters
 `pFlag`

[out] Returns `TRUE` if the optimized function or label contains debugging information; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)