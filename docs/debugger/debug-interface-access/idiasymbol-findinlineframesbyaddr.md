---
title: "IDiaSymbol::findInlineFramesByAddr | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
ms.assetid: 36a122e6-f27e-40cd-9784-cdaf279e1905
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::findInlineFramesByAddr
Retrieves an enumeration that allows a client to iterate through all of the inline frames on a given address.

## Syntax

```C++
HRESULT findInlineFramesByAddr ( 
   DWORD             isect,
   DWORD             offset,
   IDiaEnumSymbols** ppResult
);
```

#### Parameters
 `isect`

[in] Specifies the section component of the address.

 `offset`

[in] Specifies the offset component of the address.

 `ppResult`

[out] Holds an `IDiaEnumSymbols` object that contains the list of frames that are retrieved.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md)
- [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md)