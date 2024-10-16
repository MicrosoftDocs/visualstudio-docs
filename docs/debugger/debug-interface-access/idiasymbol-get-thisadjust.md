---
description: "Retrieves the logical this adjustor for the method."
title: "IDiaSymbol::get_thisAdjust"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_thisAdjust method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_thisAdjust

Retrieves the logical `this` adjustor for the method.

## Syntax

```C++
HRESULT get_thisAdjust ( 
   LONG* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the logical `this` adjustor for the method.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 In some multiple inheritance cases the method itself must calculate a true `this` value by adding an offset to `this`.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
