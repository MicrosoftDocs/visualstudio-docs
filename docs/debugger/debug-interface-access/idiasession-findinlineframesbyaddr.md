---
description: "IDiaSession::findInlineFramesByAddr retrieves an enumeration that allows a client to iterate through all of the inline frames on a given address."
title: "IDiaSession::findInlineFramesByAddr | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
ms.assetid: e7dc1ac7-bb09-45be-96d2-365a9b7336e4
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSession::findInlineFramesByAddr
Retrieves an enumeration that allows a client to iterate through all of the inline frames on a given address.

## Syntax

```C++
HRESULT findInlineFramesByAddr ( 
   IDiaSymbol*       parent,   DWORD             isect,
   DWORD             offset,
   IDiaEnumSymbols** ppResult
);
```

#### Parameters
 `parent`

[in] An `IDiaSymbol` object representing the parent.

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
