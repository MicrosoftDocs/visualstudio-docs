---
description: Retrieves the line number in the source file.
title: "IDiaLineNumber::get_lineNumber"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLineNumber::get_lineNumber method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaLineNumber::get_lineNumber

Retrieves the line number in the source file.

## Syntax

```c++
HRESULT get_lineNumber ( 
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the line number in the source file.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## Example

```c++
CComPtr< IDiaLineNumber> pLine;
DWORD linenum;
pLine->get_lineNumber( &linenum );
```

## See also

- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)
