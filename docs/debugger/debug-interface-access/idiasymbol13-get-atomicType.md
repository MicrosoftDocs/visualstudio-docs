---
title: IDiaSymbol13::get_atomicType
description: Retrieves whether the symbol represents a C11 _Atomic type.
ms.date: 12/08/2025
ms.topic: reference
helpviewer_keywords:
  - "IDiaSymbol13::get_atomicType"
dev_langs:
  - "C++"
author: mikejonesdocs
manager: mrojacobs
---

# IDiaSymbol13::get_atomicType

Determines if the symbol represents a C11 `_Atomic` type. This property is part of the **IDiaSymbol13** interface introduced in DIA SDK version 13.

## Syntax

```cpp
HRESULT get_atomicType(
    BOOL *pIsAtomic
```

#### Parameters

 `pIsAtomic`

[out] Pointer to a BOOL that receives TRUE if the symbol is a C11 `_Atomic` type; otherwise FALSE.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Remarks

This property is relevant for compilers and toolchains that emit `_Atomic` type information into PDBs.

If the symbol does not represent a C11 `_Atomic` type, the method returns `S_FALSE` and does not modify `pIsAtomic`.

To access this property, obtain the `IDiaSymbol13` interface by calling `QueryInterface` on an existing `IDiaSymbol12` instance.

## See also

- [`IDiaSymbol13`](../../debugger/debug-interface-access/idiasymbol13.md)
- [`DiaTagValue`](../../debugger/debug-interface-access/diatagvalue.md)
