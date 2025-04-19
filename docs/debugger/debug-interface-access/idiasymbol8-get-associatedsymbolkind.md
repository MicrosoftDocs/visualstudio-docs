---
description: "Retrieves the associated symbol kind."
title: "IDiaSymbol8::get_associatedSymbolKind"
ms.date: "07/15/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol8::get_associatedSymbolKind method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol8::get_associatedSymbolKind

Retrieves the associated symbol kind.

## Syntax

```C++
HRESULT get_associatedSymbolKind(
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns a value from [`CV_AssociationKind_e`](../../debugger/debug-interface-access/cv-associationkind-e.md).

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol8`](../../debugger/debug-interface-access/idiasymbol8.md)
- [`CV_AssociationKind_e`](../../debugger/debug-interface-access/cv-associationkind-e.md)

