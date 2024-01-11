---
description: "Retrieves a unique source file identifier for the source file that contributed this line."
title: "IDiaLineNumber::get_sourceFileId"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLineNumber::get_sourceFileId method"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
---
# IDiaLineNumber::get_sourceFileId

Retrieves a unique source file identifier for the source file that contributed this line.

## Syntax

```C++
HRESULT get_sourceFileId ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the unique source file identifier for the source file that contributed this line.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)
