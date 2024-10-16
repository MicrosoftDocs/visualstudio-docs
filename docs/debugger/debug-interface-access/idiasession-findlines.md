---
description: Retrieves line numbers within specified compiland and source file identifiers.
title: "IDiaSession::findLines"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::findLines method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSession::findLines

Retrieves line numbers within specified compiland and source file identifiers.

## Syntax

```C++
HRESULT findLines ( 
   IDiaSymbol*           compiland,
   IDiaSourceFile*       file,
   IDiaEnumLineNumbers** ppResult
);
```

#### Parameters
 `compiland`

[in]An [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object representing the compiland. Use this interface as a context in which to search for the line numbers.

 `file`

[in] An [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md) object representing the source file in which to search for the line numbers.

 `ppResult`

[out] Returns an [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md) object that contains a list of the line numbers retrieved.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md)
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
