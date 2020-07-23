---
title: "IDiaStackFrame::get_lengthProlog | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackFrame::get_lengthProlog method"
ms.assetid: 9894c5ca-835f-41e9-a35e-70e046dfb7f0
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaStackFrame::get_lengthProlog
Retrieves the number of bytes of prologue code in the block.

## Syntax

```C++
HRESULT get_lengthProlog ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the number of bytes of prologue code.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if the property is not supported. Otherwise, returns an error code.

## See also
- [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)