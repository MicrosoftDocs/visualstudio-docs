---
title: "IDiaFrameData::get_addressSection | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaFrameData::get_addressSection method"
ms.assetid: e4eedede-4a1c-4da2-a812-b92df328fd8d
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaFrameData::get_addressSection
Retrieves the section part of the code address for the frame.

## Syntax

```C++
HRESULT get_addressSection ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the section part of the code address for the frame.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)