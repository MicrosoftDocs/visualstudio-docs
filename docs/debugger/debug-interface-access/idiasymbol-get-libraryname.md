---
title: "IDiaSymbol::get_libraryName | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_libraryName method"
ms.assetid: d04ddd9a-812d-46e4-bd39-28bdf3edfb70
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_libraryName
Retrieves the file name of the library or object file from which the object was loaded.

## Syntax

```C++
HRESULT get_libraryName ( 
   BSTR* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the file name of the library or object file from which the object was loaded.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)