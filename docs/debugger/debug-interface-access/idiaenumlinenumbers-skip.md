---
description: "Skips a specified number of line numbers in an enumeration sequence."
title: "IDiaEnumLineNumbers::Skip | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumLineNumbers::Skip method"
ms.assetid: d182c269-8c76-4d8b-8275-c6807c5ae4e1
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaEnumLineNumbers::Skip
Skips a specified number of line numbers in an enumeration sequence.

## Syntax

```C++
HRESULT Skip ( 
   ULONG celt
);
```

#### Parameters
 celt

[in] The number of line numbers in the enumeration sequence to skip.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` if there are no more line numbers to skip.

## See also
- [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md)
