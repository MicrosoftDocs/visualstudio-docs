---
description: "Retrieves the object file name to which the source was compiled."
title: "IDiaInjectedSource::get_objectFilename | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaInjectedSource::get_objectFilename method"
ms.assetid: 7c42847a-f0df-443a-a9fe-c495c1271ea8
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaInjectedSource::get_objectFilename
Retrieves the object file name to which the source was compiled.

## Syntax

```C++
HRESULT get_objectFilename ( 
   BSTR* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the object file name to which the source was compiled.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaInjectedSource](../../debugger/debug-interface-access/idiainjectedsource.md)
