---
description: "Retrieves the offset component of the address of the associated symbol."
title: "IDiaSymbol8::get_associatedSymbolOffset"
ms.date: "07/15/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol8::get_associatedSymbolOffset method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol8::get_associatedSymbolOffset

Retrieves the offset component of the address of the associated symbol.

## Syntax

```C++
HRESULT get_associatedSymbolOffset(
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the offset component of the address of the associated symbol.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol8`](../../debugger/debug-interface-access/idiasymbol8.md)
- [`IDiaSymbol8::get_associatedSymbolSection`](../../debugger/debug-interface-access/idiasymbol8-get-associatedsymbolsection.md)
- [`IDiaSymbol8::get_associatedSymbolAddr`](../../debugger/debug-interface-access/idiasymbol8-get-associatedsymboladdr.md)
- [`IDiaSymbol8::get_associatedSymbolRva`](../../debugger/debug-interface-access/idiasymbol8-get-associatedsymbolrva.md)
