---
description: "IDiaSession::findInlineeLinesByVA retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, by the specified parent symbol and are contained within the specified virtual address (VA)."
title: "IDiaSession::findInlineeLinesByVA | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
ms.assetid: dffe6594-e0d1-4ed5-aeea-8773f88d82a6
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSession::findInlineeLinesByVA
Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, by the specified parent symbol and are contained within the specified virtual address (VA).

## Syntax

```C++
HRESULT findInlineeLinesByVA ( 
   IDiaSymbol*           parent,   ULONGLONG             va,   DWORD                 length,
   IDiaEnumLineNumbers** ppResult
);
```

#### Parameters
 `parent`

[in] An `IDiaSymbol` object representing the parent.

 `va`

[in] Specifies the address as a VA.

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
