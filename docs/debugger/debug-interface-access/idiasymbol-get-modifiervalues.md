---
description: "Retrieves the set of modifiers for this symbol."
title: "IDiaSymbol::get_modifierValues"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_modifierValues method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_modifierValues

Retrieves an array of [`modifiers`](../../debugger/debug-interface-access/cv-modifier-e.md) affecting the symbol.

## Syntax

```C++
HRESULT get_modifierValues(
    DWORD cnt,
    DWORD *pcnt,
    DWORD *pModifiers
);
```

#### Parameters

 `cnt`

[in] The number of DWORDs pointed to by the buffer `pModifiers`.

 `pcnt`

[out] Returns the number of valid properties set in `pModifiers`. 

 `pModifiers`

[out] Returns an array of [`CV_modifier_e`](../../debugger/debug-interface-access/cv-modifier-e.md) values.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`CV_modifier_e`](../../debugger/debug-interface-access/cv-modifier-e.md)
- [`IDiaSymbol::get_numberOfModifers`](../../debugger/debug-interface-access/idiasymbol-get-numberofmodifiers.md)
