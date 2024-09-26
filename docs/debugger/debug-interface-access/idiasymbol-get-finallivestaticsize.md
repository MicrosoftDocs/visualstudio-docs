---
description: Retrieves the final static size of live function, after inlining.
title: "IDiaSymbol::get_finalLiveStaticSize"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_finalLiveStaticSize method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_finalLiveStaticSize

Retrieves the final static size of live function, after inlining.

## Syntax

```C++
HRESULT get_finalLiveStaticSize ( 
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the count of live instructions in the function. See remarks.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Remarks

This is the number of live instructions in the function. For the training profile in use, only instructions that are executed at least once are counted as live. To get the total size of the function, including dead instructions (that is, instructions never executed by the training data), use [`IDiaSymbol::get_staticSize`](../../debugger/debug-interface-access/idiasymbol-get-staticsize.md). To get the number of instructions executed in this function use [`IDiaSymbol::get_PGODynamicInstructionCount`](../../debugger/debug-interface-access/idiasymbol-get-pgodynamicinstructioncount.md).

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`IDiaSymbol::get_staticSize`](../../debugger/debug-interface-access/idiasymbol-get-staticsize.md)
- [`IDiaSymbol::get_PGODynamicInstructionCount`](../../debugger/debug-interface-access/idiasymbol-get-pgodynamicinstructioncount.md)
- [Profile-guided optimizations](/cpp/build/profile-guided-optimizations)
