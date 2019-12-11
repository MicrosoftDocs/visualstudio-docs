---
title: "IDiaEnumSymbolsByAddr::symbolByVA | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSymbolsByAddr::symbolByVA method"
ms.assetid: ac84339f-70c6-48ed-85d0-6d7d1b5194e8
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaEnumSymbolsByAddr::symbolByVA
Positions the enumerator by performing a lookup by virtual address (VA).

## Syntax

```C++
HRESULT symbolByVA ( 
   DWORD**      virtualAddress,
   IDiaSymbol** ppsymbol
);
```

#### Parameters
 virtualAddress

[in] Virtual address.

 ppsymbol

[out] Returns an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object representing the symbol found.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if the symbol could not be found. Otherwise, returns an error code.

## See also
- [IDiaEnumSymbolsByAddr](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)