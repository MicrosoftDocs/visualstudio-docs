---
description: "Skips a specified number of debug streams in an enumeration sequence."
title: "IDiaEnumDebugStreams::Skip | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumDebugStreams::Skip method"
ms.assetid: 6ec7753c-d7af-4879-b107-1b3442e0b025
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaEnumDebugStreams::Skip
Skips a specified number of debug streams in an enumeration sequence.

## Syntax

```C++
HRESULT Skip ( 
   ULONG celt
);
```

#### Parameters
 `celt`

[in] The number of debug streams in the enumeration sequence to skip.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` if there are no more records to skip.

## See also
- [IDiaEnumDebugStreams](../../debugger/debug-interface-access/idiaenumdebugstreams.md)
