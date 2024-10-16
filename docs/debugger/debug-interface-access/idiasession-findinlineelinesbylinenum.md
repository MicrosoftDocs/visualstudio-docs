---
description: Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in the specified source file and line number.
title: "IDiaSession::findInlineeLinesByLinenum"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSession::findInlineeLinesByLinenum

Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in the specified source file and line number.

## Syntax

```C++
HRESULT findInlineeLinesByVA ( 
   IDiaSymbol*           compiland,
   IDiaSourceFile*       file,
   DWORD                 linenum,
   DWORD                 column,
   IDiaEnumLineNumbers** ppResult
);
```

#### Parameters
 `compiland`

[in] An [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object that represents the compiland in which to search for the line numbers. This parameter cannot be `NULL`.

 `file`

[in] An [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md) object that represents the source file in which to search. This parameter cannot be `NULL`.

 `linenum`

[in] Specifies a one-based line number.

> [!NOTE]
> You cannot use zero to specify all lines (use the [IDiaSession::findLines](../../debugger/debug-interface-access/idiasession-findlines.md) method to find all lines).

 `column`

[in] Specifies the column number. Use zero to specify all columns. A column is a byte offset into a line.

 `ppResult`

[out] Returns an [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md) object that contains a list of the line numbers that were retrieved.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md)
- [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md)
