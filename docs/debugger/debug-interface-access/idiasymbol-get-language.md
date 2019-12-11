---
title: "IDiaSymbol::get_language | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_language method"
ms.assetid: c759ad3c-1c21-4234-869b-86aa3a608a38
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_language
Retrieves the language of the source.

## Syntax

```C++
HRESULT get_language ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns a value from the [CV_CFL_LANG Enumeration](../../debugger/debug-interface-access/cv-cfl-lang.md) enumeration that specifies the language of the source.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [CV_CFL_LANG Enumeration](../../debugger/debug-interface-access/cv-cfl-lang.md)