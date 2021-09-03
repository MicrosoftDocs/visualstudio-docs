---
description: "Retrieves an array of compiler-specific type identifier values for this symbol."
title: "IDiaSymbol::get_typeIds | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_typeIds method"
ms.assetid: 5166e647-fde5-4efe-92bf-77f8ae3fbc9b
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_typeIds
Retrieves an array of compiler-specific type identifier values for this symbol.

## Syntax

```C++
HRESULT get_typeIds ( 
   DWORD  cTypeIds,
   DWORD* pcTypeIds,
   DWORD  typeIds[]
);
```

#### Parameters
 `cTypeIds`

[in] Size of the buffer to hold the data.

 `pcTypeIds`

[out] Returns the number of `typeIds` written, or, if `typeIds` is `NULL`, then the total number of type identifiers available.

 `typeIds[]`

[out] An array that is to be filled in with the type identifiers.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
