---
description: "Retrieves a flag that specifies whether the Compiland) has been linked with the linker switch /LTCG (Link-time Code Generation)(/cpp/build/reference/ltcg-link-time-code-generation), which aids in whole program optimization."
title: "IDiaSymbol::get_isLTCG"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_isLTCG method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_isLTCG

Retrieves a flag that specifies whether the [Compiland](../../debugger/debug-interface-access/compiland.md) has been linked with the linker switch [/LTCG (Link-time Code Generation)](/cpp/build/reference/ltcg-link-time-code-generation), which aids in whole program optimization. This switch applies only to managed code.

## Syntax

```C++
HRESULT get_iSLTCG(
   BOOL *pFlag
);
```

#### Parameters
 pFlag

[out] Returns `TRUE` if the `compiland` was linked with the /LTCG linker switch; otherwise, returns `FALSE`.

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
