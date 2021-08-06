---
description: "Retrieves a specified number of debug streams in the enumeration sequence."
title: "IDiaEnumDebugStreams::Next | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumDebugStreams::Next method"
ms.assetid: eb8eae5a-be27-45f4-a7bd-6e4ef0652385
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaEnumDebugStreams::Next
Retrieves a specified number of debug streams in the enumeration sequence.

## Syntax

```C++
HRESULT Next ( 
   ULONG                     celt,
   IDiaEnumDebugStreamData** rgelt,
   ULONG*                    pceltFetched
);
```

#### Parameters
 celt

[in] The number of debug streams in the enumerator to be retrieved.

 rgelt

[out] Returns an array of [IDiaEnumDebugStreamData](../../debugger/debug-interface-access/idiaenumdebugstreamdata.md) objects that represents the debug streams being retrieved.

 pceltFetched

[out] Returns the number of debug streams returned.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if there are no more streams. Otherwise, returns an error code.

## See also
- [IDiaEnumDebugStreams](../../debugger/debug-interface-access/idiaenumdebugstreams.md)
