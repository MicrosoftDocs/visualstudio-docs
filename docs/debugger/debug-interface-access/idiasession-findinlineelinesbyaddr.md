---
description: "IDiaSession::findInlineeLinesByAddr retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, by the specified parent symbol and are contained within the specified address range."
title: "IDiaSession::findInlineeLinesByAddr | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
ms.assetid: bb70e408-eed1-4c9c-b5b1-44323125f48b
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSession::findInlineeLinesByAddr
Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, by the specified parent symbol and are contained within the specified address range.

## Syntax

```C++
HRESULT findInlineeLinesByAddr ( 
   IDiaSymbol*           parent,   DWORD                 isect,   DWORD                 offset,   DWORD                 length,
   IDiaEnumLineNumbers** ppResult
);
```

#### Parameters
 `parent`

[in] An `IDiaSymbol` object representing the parent.

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
