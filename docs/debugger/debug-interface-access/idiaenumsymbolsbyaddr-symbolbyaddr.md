---
description: "Positions the enumerator by performing a lookup by image section number and offset."
title: "IDiaEnumSymbolsByAddr::symbolByAddr"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSymbolsByAddr::symbolByAddr method"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
---
# IDiaEnumSymbolsByAddr::symbolByAddr

Positions the enumerator by performing a lookup by image section number and offset.

## Syntax

```C++
HRESULT symbolByAddr ( 
   DWORD**      isect,
   DWORD**      offsect,
   IDiaSymbol** ppsymbol
);
```

#### Parameters
 isect

[in] Image section number.

 offsect

[in] Offset in section.

 ppsymbol

[out] Returns an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object representing the symbol found.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if the symbol could not be found. Otherwise, returns an error code.

## See also
- [IDiaEnumSymbolsByAddr](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
