---
description: "IDiaFrameData::get_maxStack retrieves the maximum number of bytes pushed on the stack in the frame."
title: "IDiaFrameData::get_maxStack | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaFrameData::get_maxStack method"
ms.assetid: 2585e13c-c0f3-49fe-9a84-08adb0dbeaa4
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaFrameData::get_maxStack
Retrieves the maximum number of bytes pushed on the stack in the frame.

## Syntax

```C++
HRESULT get_maxStack ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the maximum number of bytes pushed on the stack.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## Remarks
 The value returned by this method is typically used in the interpretation of a program string (see the [IDiaFrameData::get_program](../../debugger/debug-interface-access/idiaframedata-get-program.md) method for the definition of a program string).

## See also
- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)
- [IDiaFrameData::get_program](../../debugger/debug-interface-access/idiaframedata-get-program.md)
