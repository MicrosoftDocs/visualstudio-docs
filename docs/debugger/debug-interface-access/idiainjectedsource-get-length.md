---
description: Retrieves the number of bytes of code.
title: "IDiaInjectedSource::get_length"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaInjectedSource::get_length method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaInjectedSource::get_length

Retrieves the number of bytes of code.

## Syntax

```c++
HRESULT get_length ( 
   ULONGLONG* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the number of bytes of code.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## Remarks

The value returned by this method is the length of the source code and is the same value as returned by the [IDiaInjectedSource::get_source](../../debugger/debug-interface-access/idiainjectedsource-get-source.md) method.

## See also

- [IDiaInjectedSource](../../debugger/debug-interface-access/idiainjectedsource.md)
- [IDiaInjectedSource::get_source](../../debugger/debug-interface-access/idiainjectedsource-get-source.md)
