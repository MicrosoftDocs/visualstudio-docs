---
title: IDiaSymbol12::get_atomicType
description: Retrieves whether the symbol represents a C11 _Atomic type.
ms.date: 1/08/2026
ms.topic: reference
helpviewer_keywords:
  - "IDiaSymbol13::get_atomicType"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol12::get_atomicType

Determines if the symbol represents a C11 `_Atomic` type. This property is part of the **IDiaSymbol12** interface.

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

If the symbol doesn't represent a C11 `_Atomic` type, the method returns `S_FALSE` and doesn't modify `pIsAtomic`.

To access this property, obtain the `IDiaSymbol12` interface by calling `QueryInterface` on an existing `IDiaSymbol12` instance.

## See also

- [`IDiaSymbol12`](../../debugger/debug-interface-access/idiasymbol12.md)
- [`DiaTagValue`](../../debugger/debug-interface-access/diatagvalue.md)
