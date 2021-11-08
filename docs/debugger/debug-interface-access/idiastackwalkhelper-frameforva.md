---
description: "Retrieves the stack frame that contains the specified virtual address."
title: "IDiaStackWalkHelper::frameForVA | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkHelper2::frameForVA method"
ms.assetid: f35fc61b-f8dd-473a-b583-82c304059422
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaStackWalkHelper::frameForVA
Retrieves the stack frame that contains the specified virtual address.

## Syntax

```C++
HRESULT frameForVA( 
   ULONGLONG        va,
   IDiaFrameData**  ppFrame
);
```

#### Parameters
 `va`

[in] The virtual address for the frame data.

 `ppFrame`

[out] An [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md) object that represents the stack frame at the specified address.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaStackWalkHelper](../../debugger/debug-interface-access/idiastackwalkhelper.md)
- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)
