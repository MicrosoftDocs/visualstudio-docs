---
title: "IDiaFrameData::get_type | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaFrameData::get_type method"
ms.assetid: efca38b5-c479-4d0a-a164-f903f25c5509
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaFrameData::get_type
Retrieves the compiler-specific frame type.

## Syntax

```C++
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