---
description: "Retrieves the edge count between a caller/callee and it's parent."
title: "IDiaSymbol::get_PGOEdgeCount"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_PGOEdgeCount method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_PGOEdgeCount

Retrieves the edge count between a caller/callee and it's parent.

## Syntax

```C++
HRESULT get_PGOEdgeCount ( 
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the edge count between a caller/calle.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [Profile-guided optimizations](/cpp/build/profile-guided-optimizations)
