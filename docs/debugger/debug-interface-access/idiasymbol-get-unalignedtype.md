---
description: "Retrieves a flag that specifies whether the user-defined data type is unaligned."
title: "IDiaSymbol::get_unalignedType | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_unalignedType method"
ms.assetid: fdcb38fb-490e-4d15-b4e5-3770043a366c
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_unalignedType
Retrieves a flag that specifies whether the user-defined data type is unaligned.

## Syntax

```C++
HRESULT get_unalignedType ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the user-defined data type is unaligned; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
