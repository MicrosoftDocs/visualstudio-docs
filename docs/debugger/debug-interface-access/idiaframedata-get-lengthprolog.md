---
title: "IDiaFrameData::get_lengthProlog | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaFrameData::get_lengthProlog method"
ms.assetid: 5f042ff1-e74e-430a-be34-d2cf1b18eff2
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaFrameData::get_lengthProlog
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
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## Remarks
 The prologue code is a sequence of instructions that preserves registers, sets the CPU state, and establishes the stack for the function.

## See also
- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)