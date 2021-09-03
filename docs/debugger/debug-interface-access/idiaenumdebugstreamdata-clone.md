---
description: "Creates an enumerator that contains the same enumerated sequence as the current debug data stream enumerator."
title: "IDiaEnumDebugStreamData::Clone | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumDebugStreamData::Clone method"
ms.assetid: e7f17750-0694-4634-bf34-c821cd265c2f
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaEnumDebugStreamData::Clone
Creates an enumerator that contains the same enumerated sequence as the current enumerator.

## Syntax

```C++
HRESULT Clone ( 
   IDiaEnumDebugStreamData** ppenum
);
```

#### Parameters
 ppenum

[out] Returns an [IDiaEnumDebugStreamData](../../debugger/debug-interface-access/idiaenumdebugstreamdata.md) object that contains the duplicated sequence of debug data stream records.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaEnumDebugStreamData](../../debugger/debug-interface-access/idiaenumdebugstreamdata.md)
