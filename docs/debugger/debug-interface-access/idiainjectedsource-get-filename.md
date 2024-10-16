---
description: Retrieves the file name for the source.
title: "IDiaInjectedSource::get_filename"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaInjectedSource::get_filename method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaInjectedSource::get_filename

Retrieves the file name for the source.

## Syntax

```c++
HRESULT get_filename ( 
   BSTR* pRetVal
);
```

#### Parameters

pRetVal

[out] Returns the file name for the source.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also

- [IDiaInjectedSource](../../debugger/debug-interface-access/idiainjectedsource.md)
