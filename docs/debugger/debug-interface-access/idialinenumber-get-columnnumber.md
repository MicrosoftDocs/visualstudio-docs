---
description: "Retrieves the column number where the expression or statement begins."
title: "IDiaLineNumber::get_columnNumber | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLineNumber::get_columnNumber method"
ms.assetid: e317f29a-6525-46a7-8421-33985392f8fd
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaLineNumber::get_columnNumber
Retrieves the column number where the expression or statement begins.

## Syntax

```cpp
HRESULT get_columnNumber ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the column number where the expression or statement begins. If the value is zero, then column information is not present.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## Remarks
 The column value returned by this method is a byte offset into the line to the first character of the statement on the line.

## See also
- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)
