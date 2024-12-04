---
description: "Retrieves a flag indicating whether a local symbol's location liveness is dependent upon the control flow of the function."
title: "IDiaSymbol::get_isLocationControlFlowDependent"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_isLocationControlFlowDependent method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_isLocationControlFlowDependent

Retrieves a flag indicating whether a local symbol's location liveness is dependent upon the control flow of the function.

## Syntax

```C++
HRESULT get_isLocationControlFlowDependent ( 
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` if the current symbol location is only live or valid depending upon the control flow followed to reach this address; otherwise, returns `FALSE`.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
