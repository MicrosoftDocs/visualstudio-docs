---
description: "Retrieves the frame type."
title: "IDiaStackFrame::get_type | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackFrame::get_type method"
ms.assetid: 99daa97b-5c05-455d-bd1e-800762ccf7c9
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaStackFrame::get_type
Retrieves the frame type.

## Syntax

```C++
HRESULT get_type ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns a value from the [StackFrameTypeEnum Enumeration](../../debugger/debug-interface-access/stackframetypeenum.md) enumeration.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if the property is not supported. Otherwise, returns an error code.

## See also
- [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)
- [StackFrameTypeEnum Enumeration](../../debugger/debug-interface-access/stackframetypeenum.md)
