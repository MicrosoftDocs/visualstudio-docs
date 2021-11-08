---
description: "Retrieves a flag that specifies whether the function is virtual."
title: "IDiaSymbol::get_virtual | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_virtual method"
ms.assetid: 97e3ad51-8ef3-4446-ab33-3cb34a21b7a0
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_virtual
Retrieves a flag that specifies whether the function is virtual.

## Syntax

```C++
HRESULT get_virtual ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the function is virtual; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
