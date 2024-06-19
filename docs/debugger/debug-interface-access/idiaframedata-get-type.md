---
description: Retrieves the compiler-specific frame type.
title: "IDiaFrameData::get_type"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaFrameData::get_type method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaFrameData::get_type

Retrieves the compiler-specific frame type.

## Syntax

```c++
HRESULT get_type ( 
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns a value from the [StackFrameTypeEnum Enumeration](../../debugger/debug-interface-access/stackframetypeenum.md) enumeration that indicates the compiler-specific frame type.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also

- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)
- [StackFrameTypeEnum Enumeration](../../debugger/debug-interface-access/stackframetypeenum.md)
