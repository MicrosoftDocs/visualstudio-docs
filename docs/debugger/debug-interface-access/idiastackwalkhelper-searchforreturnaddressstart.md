---
description: Searches the specified stack frame for a return address at or near the specified stack address.
title: "IDiaStackWalkHelper::searchForReturnAddressStart"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkHelper::searchForReturnAddressStart method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaStackWalkHelper::searchForReturnAddressStart

Searches the specified stack frame for a return address at or near the specified stack address.

## Syntax

```C++
HRESULT searchForReturnAddressStart( 
   IDiaFrameData*  frame,
   ULONGLONG       startAddress,
   ULONGLONG*      returnAddress
);
```

#### Parameters
 `frame`

[in] An [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md) object that represents the current stack frame.

 `startAddress`

[in] A virtual memory address from which to begin searching.

 `ReturnAddress`

[out] Returns the nearest function return address to `startAddress`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaStackWalkHelper](../../debugger/debug-interface-access/idiastackwalkhelper.md)
- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)
