---
description: "Retrieves the number of segments."
title: "IDiaEnumSegments::get_Count | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSegments::get_Count method"
ms.assetid: c62a0fda-17b8-4cf6-b321-6014ce581096
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaEnumSegments::get_Count
Retrieves the number of segments.

## Syntax

```C++
HRESULT get_Count ( 
   LONG* pRetVal
);
```

#### Parameters
 pRetVal
- [out, retval] Returns the number of segments.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaEnumSegments](../../debugger/debug-interface-access/idiaenumsegments.md)
- [IDiaEnumSegments::Item](../../debugger/debug-interface-access/idiaenumsegments-item.md)
