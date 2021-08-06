---
description: "Retrieves a flag that specifies whether the user-defined data type has overloaded operators."
title: "IDiaSymbol::get_overloadedOperator | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_overloadedOperator method"
ms.assetid: 257a9894-e980-47ae-bdc0-c5e2293ea734
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_overloadedOperator
Retrieves a flag that specifies whether the user-defined data type has overloaded operators.

## Syntax

```C++
HRESULT get_overloadedOperator ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the user-defined data type has overloaded operators; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
