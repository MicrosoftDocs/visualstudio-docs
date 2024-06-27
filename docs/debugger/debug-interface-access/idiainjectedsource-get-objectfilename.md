---
description: Retrieves the object file name to which the source was compiled.
title: "IDiaInjectedSource::get_objectFilename"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaInjectedSource::get_objectFilename method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaInjectedSource::get_objectFilename

Retrieves the object file name to which the source was compiled.

## Syntax

```c++
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
