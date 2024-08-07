---
description: "Retrieves the static instruction count."
title: "IDiaSymbol::get_staticSize"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_staticSize method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_staticSize

Retrieves the static instruction count.

## Syntax

```C++
HRESULT get_staticSize ( 
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the count of instructions in the function. See remarks,

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Remarks

This is the total number of instructions in the function. To get only the count of live instructions, use [`IDiaSymbol::get_finalLiveStaticSize`](../../debugger/debug-interface-access/idiasymbol-get-finallivestaticsize.md). To get the number of instructions executed in this function use [`IDiaSymbol::get_PGODynamicInstructionCount`](../../debugger/debug-interface-access/idiasymbol-get-pgodynamicinstructioncount.md). 

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`IDiaSymbol::get_finalLiveStaticSize`](../../debugger/debug-interface-access/idiasymbol-get-finallivestaticsize.md)
- [`IDiaSymbol::get_PGODynamicInstructionCount`](../../debugger/debug-interface-access/idiasymbol-get-pgodynamicinstructioncount.md)
- [Profile-guided optimizations](/cpp/build/profile-guided-optimizations)
