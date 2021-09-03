---
description: "Retrieves a flag that specifies whether a class is an intrinsic type."
title: "IDiaSymbol::get_intrinsic | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_intrinsic method"
ms.assetid: f969f595-d9f9-48b9-adaa-63a6e4e09575
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_intrinsic
Retrieves a flag that specifies whether a class is an intrinsic type.

## Syntax

```C++
HRESULT get_intrinsic( 
   BOOL* pRetVal)
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the class is an intrinsic type; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks

## Requirements
 Header: Dia2.h

 Library: diaguids.lib

 DLL: msdia100.dll

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
