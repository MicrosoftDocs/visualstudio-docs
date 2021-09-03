---
description: "Creates an enumerator that contains the same enumeration state as the current debug stream enumerator."
title: "IDiaEnumDebugStreams::Clone | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumDebugStreams::Clone method"
ms.assetid: e85ec592-de97-4f95-a774-1623315ba415
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaEnumDebugStreams::Clone
Creates an enumerator that contains the same enumeration state as the current enumerator.

## Syntax

```C++
HRESULT Clone ( 
   IDiaEnumDebugStreams** ppenum
);
```

#### Parameters
 `ppenum`

[out] Returns an [IDiaEnumDebugStreams](../../debugger/debug-interface-access/idiaenumdebugstreams.md) object that contains a duplicate of the  enumerator. The streams are not duplicated, only the enumerator.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaEnumDebugStreams](../../debugger/debug-interface-access/idiaenumdebugstreams.md)
