---
description: "Retrieves the inlinee symbol from a SymTagInlineSite symbol."
title: "IDiaSymbol3::get_inlinee"
ms.date: "07/12/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol3::get_inlinee method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol3::get_inlinee

Retrieves the inlinee symbol from a `SymTagInlineSite` symbol.

## Syntax

```C++
HRESULT get_inlinee ( 
   IDiaSymbol** pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md) for the inlined function if this is an `SymTagInlineSite` symbol.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol3`](../../debugger/debug-interface-access/idiasymbol3.md)
- [`IDiaSymbol3::get_inlineeId`](../../debugger/debug-interface-access/idiasymbol3-get-inlineeId.md)
- [`SymTagEnum`](../../debugger/debug-interface-access/symtagenum.md)