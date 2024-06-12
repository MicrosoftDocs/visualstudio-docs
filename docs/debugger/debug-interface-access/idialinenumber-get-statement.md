---
description: Retrieves a flag indicating that this line information describes the beginning of a statement, rather than an expression, in the program source.
title: "IDiaLineNumber::get_statement"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLineNumber::get_statement method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaLineNumber::get_statement

Retrieves a flag indicating that this line information describes the beginning of a statement, rather than an expression, in the program source.

## Syntax

```c++
HRESULT get_statement ( 
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` if this line information describes the beginning of a statement in the program source.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## Remarks

Statements can span multiple lines. This method indicates if the associated line number marks the beginning of such a multi-line statement.

## See also

- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)
