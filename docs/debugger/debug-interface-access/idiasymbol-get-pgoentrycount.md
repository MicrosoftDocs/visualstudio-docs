---
description: "Retrieves the total invocation count in PGO training."
title: "IDiaSymbol::get_PGOEntryCount"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_PGOEntryCount method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_PGOEntryCount

Retrieves the total invocation count in PGO training.

## Syntax

```C++
HRESULT get_PGOEntryCount ( 
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the total invocation count in PGO training.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [Profile-guided optimizations](/cpp/build/profile-guided-optimizations)
