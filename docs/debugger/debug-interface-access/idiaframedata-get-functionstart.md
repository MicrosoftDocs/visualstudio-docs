---
title: "IDiaFrameData::get_functionStart | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaFrameData::get_functionStart method"
ms.assetid: 49fd24fb-65c2-4812-8303-56a968353e1b
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaFrameData::get_functionStart
Retrieves a flag that indicates whether the block contains the entry point of a function.

## Syntax

```C++
HRESULT get_functionStart ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the block contains the entry point; otherwise returns `FALSE`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## Remarks
 It is possible for a stack frame to not be the start of a function because the frame represents an inline method or function inserted into a function.

## See also
- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)