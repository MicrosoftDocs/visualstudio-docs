---
description: "Retrieves a flag that specifies whether the user-defined data type appears in a non-global lexical scope."
title: "IDiaSymbol::get_scoped | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_scoped method"
ms.assetid: 588163f7-958e-4072-bf66-db5c5f07d3cb
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_scoped
Retrieves a flag that specifies whether the user-defined data type appears in a non-global lexical scope.

## Syntax

```C++
HRESULT get_scoped ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the user-defined data type appears in a non-global lexical scope; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
