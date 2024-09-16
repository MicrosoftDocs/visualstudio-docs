---
description: "IDiaSymbol::findInlineeLinesByAddr retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in this symbol within the specified address range."
title: "IDiaSymbol::findInlineeLinesByAddr"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::findInlineeLinesByAddr

Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in this symbol within the specified address range.

## Syntax

```C++
HRESULT findInlineeLinesByAddr ( 
   DWORD                 isect,
   DWORD                 offset,
   DWORD                 length,
   IDiaEnumLineNumbers** ppResult
);
```

#### Parameters
 `isect`

[in] Specifies the section component of the address.

 `offset`

[in] Specifies the offset component of the address.

 `length`

[in] Specifies the address range, in number of bytes, to cover with this query.

 `ppResult`

[out] Holds an `IDiaEnumLineNumbers` object that contains the list of line numbers that are retrieved.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md)
- [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md)
- [IDiaSession::findInlineeLines](../../debugger/debug-interface-access/idiasession-findinlineelines.md)
