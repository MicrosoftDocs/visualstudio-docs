---
description: Retrieves the section part of the memory address where a block begins.
title: "IDiaLineNumber::get_addressSection"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLineNumber::get_addressSection method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaLineNumber::get_addressSection

Retrieves the section part of the memory address where a block begins.

## Syntax

```c++
HRESULT get_addressSection ( 
   DWORD* pRetVal
);
```

#### Parameters

pRetVal

[out] Returns the section part of the memory address where a block begins.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## Example

```c++
CComPtr< IDiaLineNumber > pLine;
DWORD seg;
pLine->get_addressSection( &seg );
```

## See also

- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)
- [IDiaLineNumber::get_addressOffset](../../debugger/debug-interface-access/idialinenumber-get-addressoffset.md)
