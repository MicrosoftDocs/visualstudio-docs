---
description: "Retrieves the line number in the source file."
title: "IDiaLineNumber::get_lineNumber | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLineNumber::get_lineNumber method"
ms.assetid: 2dff3fd9-097d-4645-bc1b-cb65ecbc42a6
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaLineNumber::get_lineNumber
Retrieves the line number in the source file.

## Syntax

```C++
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

```C++
CComPtr< IDiaLineNumber> pLine;
DWORD linenum;
pLine->get_lineNumber( &linenum );
```

## See also
- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)
