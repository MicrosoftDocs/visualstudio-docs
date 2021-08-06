---
description: "Skips a specified number of records in an enumerated sequence."
title: "IDiaEnumDebugStreamData::Skip | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumDebugStreamData::Skip method"
ms.assetid: 106ae1d3-a379-4077-babf-2665e697b0c4
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaEnumDebugStreamData::Skip
Skips a specified number of records in an enumerated sequence.

## Syntax

```C++
HRESULT Skip ( 
   ULONG celt
);
```

#### Parameters
 celt

[in] The number of records to skip in the enumerated sequence.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` if there are no more records to skip.

## See also
- [IDiaEnumDebugStreamData](../../debugger/debug-interface-access/idiaenumdebugstreamdata.md)
