---
description: Retrieves the offset part of the memory address where a block begins.
title: "IDiaLineNumber::get_addressOffset"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLineNumber::get_addressOffset method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaLineNumber::get_addressOffset

Retrieves the offset part of the memory address where a block begins.

## Syntax

```c++
HRESULT get_addressOffset ( 
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the offset part of the memory address where a block begins.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## Example

```c++
CComPtr< IDiaLineNumber > pLine;
DWORD offset;
pLine->get_addressOffset( &offset);
```

## See also

- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)
- [IDiaLineNumber::get_addressSection](../../debugger/debug-interface-access/idialinenumber-get-addresssection.md)
