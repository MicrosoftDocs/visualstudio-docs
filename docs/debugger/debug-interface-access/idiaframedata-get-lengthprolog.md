---
description: "IDiaFrameData::get_lengthProlog retrieves the number of bytes of prologue code in the block."
title: "IDiaFrameData::get_lengthProlog"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaFrameData::get_lengthProlog method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaFrameData::get_lengthProlog

Retrieves the number of bytes of prologue code in the block.

## Syntax

```c++
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
