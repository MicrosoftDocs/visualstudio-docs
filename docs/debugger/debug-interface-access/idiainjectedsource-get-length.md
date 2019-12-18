---
title: "IDiaInjectedSource::get_length | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaInjectedSource::get_length method"
ms.assetid: 38b88b8b-c2e0-4b2d-8b8b-9ff373733e78
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaInjectedSource::get_length
Retrieves the number of bytes of code.

## Syntax

```C++
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