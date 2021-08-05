---
description: "Retrieves the one-based source column number where the expression or statement ends."
title: "IDiaLineNumber::get_columnNumberEnd | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLineNumber::get_columnNumberEnd method"
ms.assetid: 02fa56c1-87b6-405a-adee-3bb6bc62de2d
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaLineNumber::get_columnNumberEnd
Retrieves the one-based source column number where the expression or statement ends.

## Syntax

```C++
HRESULT get_columnNumberEnd ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the column number where the expression or statement ends. If the value is zero, then the column end information is not present.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## Remarks
 The column value returned by this method is a byte offset into the line to the position after the last character of the statement on the line.

## See also
- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)
