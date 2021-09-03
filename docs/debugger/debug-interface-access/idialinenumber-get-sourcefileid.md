---
description: "Retrieves a unique source file identifier for the source file that contributed this line."
title: "IDiaLineNumber::get_sourceFileId | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLineNumber::get_sourceFileId method"
ms.assetid: 4f482a1e-e85f-4173-98de-8e5f7622554b
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
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
