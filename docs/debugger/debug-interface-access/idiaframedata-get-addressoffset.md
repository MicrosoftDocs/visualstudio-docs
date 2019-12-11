---
title: "IDiaFrameData::get_addressOffset | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaFrameData::get_addressOffset method"
ms.assetid: b68e2e68-6483-4936-bf97-1b0a13cb75e2
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaFrameData::get_addressOffset
Retrieves the offset part of the code address for the frame.

## Syntax

```C++
HRESULT get_addressOffset ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the offset part of the code address for the frame.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)