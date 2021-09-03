---
description: "Retrieves the return address of the frame."
title: "IDiaStackFrame::get_returnAddress | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackFrame::get_returnAddress method"
ms.assetid: 0df91981-919f-48ed-9c70-4121567d645b
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaStackFrame::get_returnAddress
Retrieves the return address of the frame.

## Syntax

```C++
HRESULT get_returnAddress ( 
   ULONGLONG* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the return address of the frame.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if the property is not supported. Otherwise, returns an error code.

## See also
- [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)
