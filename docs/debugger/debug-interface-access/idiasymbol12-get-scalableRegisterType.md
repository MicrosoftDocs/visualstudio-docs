---
title: IDiaSymbol12::get_scalableRegisterType
description: Retrieves the scalable vector register type associated with a symbol.
ms.date: 12/08/2025
ms.topic: reference
helpviewer_keywords:
  - "IDiaSymbol12::get_scalableRegisterType"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol12::get_scalableRegisterType

Retrieves the scalable vector register type for the symbol. This property is part of the **IDiaSymbol12** interface.

## Syntax

```cpp
HRESULT get_scalableRegisterType(
    DWORD *pRegisterType
```

#### Parameters

 `pRegisterType`

[out] A pointer to a `DWORD` that receives the register type value.

Possible values correspond to scalable vector register kinds, such as `SVE_Z` or `SVE_P`.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property isn't available for the symbol.

## Remarks

This property is relevant for architectures that support scalable vector extensions (for example, ARM SVE).

If the symbol doesn't represent a scalable vector register, the method returns S_FALSE and `pRegisterType` isn't modified.

To access this property, obtain an `IDiaSymbol12` interface by calling `QueryInterface` on an existing `IDiaSymbol` or `IDiaSymbol12` instance.

## See also

- [`IDiaSymbol12`](../../debugger/debug-interface-access/idiasymbol12.md)
- [`DiaTagValue`](../../debugger/debug-interface-access/diatagvalue.md)
