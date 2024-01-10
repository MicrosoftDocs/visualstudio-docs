---
description: "Specifies whether the variable is optimized away."
title: "IDiaSymbol::get_isOptimizedAway"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.subservice: vs-ide-debug
---
# IDiaSymbol::get_isOptimizedAway

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Specifies whether the variable is optimized away.

## Syntax

```C++
HRESULT get_isOptimizedAway(
   BOOL* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `BOOL` that specifies whether the variable is optimized away.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
