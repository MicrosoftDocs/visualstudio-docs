---
description: Retrieves the frame size.
title: "IDiaSymbol::get_frameSize"
ms.date: "07/11/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_frameSize method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_frameSize

Retrieves the frame size.

## Syntax

```C++
HRESULT get_frameSize ( 
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the total size, in bytes, of the functions fixed stacke frame allocation.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
