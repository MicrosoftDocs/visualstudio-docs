---
title: "IDiaLineNumber::get_lineNumberEnd | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLineNumber::get_lineNumberEnd method"
ms.assetid: b101853e-2bcf-47c1-acef-e13984c7ea9d
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaLineNumber::get_lineNumberEnd
Retrieves the one-based source line number where the statement or expression ends.

## Syntax

```C++
HRESULT get_lineNumberEnd ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the line number where the statement or expression ends. If the value is zero, then the end information is not present.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)