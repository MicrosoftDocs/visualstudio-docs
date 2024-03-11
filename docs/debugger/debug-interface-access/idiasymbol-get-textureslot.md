---
description: "Retrieves the texture slot."
title: "IDiaSymbol::get_textureSlot"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_textureSlot

Retrieves the texture slot.

## Syntax

```C++
HRESULT get_textureSlot(
   DWORD* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `DWORD` that holds the texture slot.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
