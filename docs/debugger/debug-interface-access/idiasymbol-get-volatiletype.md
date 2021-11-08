---
description: "Retrieves a flag that specifies whether the user-defined data type (UDT) is volatile."
title: "IDiaSymbol::get_volatileType | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_volatileType method"
ms.assetid: 19782a4d-40a8-467b-ab7d-58bc4d812309
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_volatileType
Retrieves a flag that specifies whether the user-defined data type (UDT) is volatile.

## Syntax

```C++
HRESULT get_volatileType ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the UDT is volatile; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 In C++, a UDT can be marked with the `volatile` keyword, indicating that its contents cannot be assumed to exist from one access to the next.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
