---
title: "IDiaLineNumber::get_statement | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLineNumber::get_statement method"
ms.assetid: 22b8ee29-79ef-427f-bd05-00d255ab836b
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaLineNumber::get_statement
Retrieves a flag indicating that this line information describes the beginning of a statement, rather than an expression, in the program source.

## Syntax

```C++
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