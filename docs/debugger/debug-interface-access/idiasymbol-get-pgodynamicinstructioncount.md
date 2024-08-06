---
description: "Retrieves the dynamic instruction count calculated by training."
title: "IDiaSymbol::get_PGODynamicInstructionCount"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_PGODynamicInstructionCount method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_PGODynamicInstructionCount

Retrieves the dynamic instruction count calculated by training.

## Syntax

```C++
HRESULT get_PGODynamicInstructionCount ( 
   ULONGLONG* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the count of dynamic instructions executed during training. See remarks.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Remarks

This is the number of instructions in the function that were executed during training. FOr example if two instructions were executed twice each, this would return a dynamic instruction count of 4, meaning 4 instructions were executed during the training. To get the total size of the function, including dead instructions (i.e. instructions never executed by the training data), use [`IDiaSymbol::get_staticSize`](../../debugger/debug-interface-access/idiasymbol-get-staticsize.md). To get the number of live instructions, not multiplied by execution counts, use [`IDiaSymbol::get_finalLiveStaticSize`](../../debugger/debug-interface-access/idiasymbol-get-finallivestaticsize.md). 

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`IDiaSymbol::get_staticSize`](../../debugger/debug-interface-access/idiasymbol-get-staticsize.md)
- [`IDiaSymbol::get_finalLiveStaticSize`](../../debugger/debug-interface-access/idiasymbol-get-finallivestaticsize.md)
- [Profile-guided optimizations](/cpp/build/profile-guided-optimizations)
