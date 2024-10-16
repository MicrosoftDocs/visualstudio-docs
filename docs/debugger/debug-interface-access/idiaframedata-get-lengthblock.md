---
description: Retrieves the length, in bytes, of the block of code described by the frame.
title: "IDiaFrameData::get_lengthBlock"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaFrameData::get_lengthBlock method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaFrameData::get_lengthBlock

Retrieves the length, in bytes, of the block of code described by the frame.

## Syntax

```c++
HRESULT get_lengthBlock ( 
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the number of bytes of code in the frame.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## Remarks

The value returned by this method is typically used in the interpretation of a program string (see the [IDiaFrameData::get_program](../../debugger/debug-interface-access/idiaframedata-get-program.md) method for the definition of a program string).

## See also

- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)
- [IDiaFrameData::get_program](../../debugger/debug-interface-access/idiaframedata-get-program.md)
