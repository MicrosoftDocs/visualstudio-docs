---
description: "IDiaStackWalkHelper::searchForReturnAddress searches the specified stack frame for the nearest function return address."
title: "IDiaStackWalkHelper::searchForReturnAddress"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkHelper2::searchForReturnAddress method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaStackWalkHelper::searchForReturnAddress

Searches the specified stack frame for the nearest function return address.

## Syntax

```C++
HRESULT searchForReturnAddress( 
   IDiaFrameData*  frame,
   ULONGLONG*      returnAddress
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
- [IDiaStackWalkHelper](../../debugger/debug-interface-access/idiastackwalkhelper.md)
- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)
