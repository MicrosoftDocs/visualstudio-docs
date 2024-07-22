---
description: "Retrieves the number of modifiers that are applied to the original type."
title: "IDiaSymbol::get_numberOfModifiers"
ms.date: "07/22/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# `IDiaSymbol::get_numberOfModifiers`

Retrieves the number of modifiers that are applied to the original type.

## Syntax

```C++
HRESULT get_numberOfModifiers(
   DWORD* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `DWORD` that specifies the number of modifiers that are applied to the original type.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`IDiaSymbol::get_modifierValues`](../../debugger/debug-interface-access/idiasymbol-get-modifiervalues.md)
