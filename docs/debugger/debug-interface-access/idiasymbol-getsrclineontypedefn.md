---
description: "Retrieves the source file and line number that indicate where a specified user-defined type is defined."
title: "IDiaSymbol::getSrcLineOnTypeDefn"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::getSrcLineOnTypeDefn

Retrieves the source file and line number that indicate where a specified user-defined type is defined.

## Syntax

```C++
HRESULT getSrcLineOnTypeDefn(
   IDiaLineNumber **ppResult);
```

#### Parameters
 `ppResult`

[out] A `IDiaLineNumber` object that contains the source file and line number where the user-defined.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)
