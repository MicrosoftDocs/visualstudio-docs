---
description: "IDiaStackWalkFrame::searchForReturnAddress searches the specified stack frame for the nearest function return address."
title: "IDiaStackWalkFrame::searchForReturnAddress | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkFrame::searchForReturnAddress method"
ms.assetid: 1a54c50d-94af-4a43-ac4e-d80c5df156c3
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaStackWalkFrame::searchForReturnAddress
Searches the specified stack frame for the nearest function return address.

## Syntax

```C++
HRESULT searchForReturnAddress ( 
   IDiaFrameData* frame,
   ULONGLONG*     returnAddress
);
```

#### Parameters
 `frame`

[in] An [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md) object that represents the current stack frame.

 `returnAddress`

[out] Returns the nearest function return address.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaStackWalkFrame](../../debugger/debug-interface-access/idiastackwalkframe.md)
- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)
