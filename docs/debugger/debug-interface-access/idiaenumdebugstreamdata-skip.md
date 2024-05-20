---
description: Skips a specified number of records in an enumerated sequence.
title: "IDiaEnumDebugStreamData::Skip"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumDebugStreamData::Skip method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumDebugStreamData::Skip

Skips a specified number of records in an enumerated sequence.

## Syntax

```c++
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
