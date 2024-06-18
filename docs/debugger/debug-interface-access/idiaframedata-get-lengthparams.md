---
description: "IDiaFrameData::get_lengthParams retrieves the number of bytes of parameters pushed on the stack."
title: "IDiaFrameData::get_lengthParams"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaFrameData::get_lengthParams method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaFrameData::get_lengthParams

Retrieves the number of bytes of parameters pushed on the stack.

## Syntax

```c++
HRESULT get_lengthParams ( 
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the number of bytes of parameters.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## Remarks

The value returned by this method is typically used in the interpretation of a program string (see the [IDiaFrameData::get_program](../../debugger/debug-interface-access/idiaframedata-get-program.md) method for the definition of a program string).

## See also

- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)
- [IDiaFrameData::get_program](../../debugger/debug-interface-access/idiaframedata-get-program.md)
