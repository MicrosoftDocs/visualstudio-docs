---
description: "Positions the enumerator by performing a lookup by image section number and offset."
title: "IDiaEnumSymbolsByAddr2::symbolByAddrEx"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSymbolsByAddr2::symbolByAddrEx method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaEnumSymbolsByAddr2::symbolByAddr

Positions the enumerator by performing a lookup by image section number and offset.

## Syntax

```C++
HRESULT symbolByAddrEx (
   BOOL         fPromoteBlockSym,
   DWORD        isect,
   DWORD        offsect,
   IDiaSymbol** ppsymbol
);
```

#### Parameters
 fPromoteBlockSym

[in] Whether or not to enumerate SymTagBlock symbols or promote them to an outer/parent symbol (like SymTagFuncton or SymTagPublicSymbol). If `FALSE` returns unpromoted SymTagBlock. Otherwise behaves identically to [IDiaEnumSymbolsByAddr::symbolByAddr](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr-symbolsbyaddr.md)

 isect

[in] Image section number.

 offsect

[in] Offset in section.

 ppsymbol

[out] Returns an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object representing the symbol found.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if the symbol could not be found. Otherwise, returns an error code.

## See also
- [IDiaEnumSymbolsByAddr::symbolByAddr](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr-symbolsbyaddr.md)
- [IDiaEnumSymbolsByAddr2](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr2.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
