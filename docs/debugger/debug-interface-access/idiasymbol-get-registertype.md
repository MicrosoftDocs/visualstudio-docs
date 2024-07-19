---
description: "Retrieves the register type."
title: "IDiaSymbol::get_registerType"
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# `IDiaSymbol::get_registerType`

Retrieves the register type.

## Syntax

```C++
HRESULT get_registerType(
   DWORD* pRetVal);
```

#### Parameters

 `pRetVal`

[out] A pointer to a `DWORD` that holds the register type, a value from [`CV_HLSLREG_e`](../../debugger/debug-interface-access/cv-hlslreg-e.md).

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`CV_HLSLREG_e` Enumeration](../../debugger/debug-interface-access/cv-hlslreg-e.md)
