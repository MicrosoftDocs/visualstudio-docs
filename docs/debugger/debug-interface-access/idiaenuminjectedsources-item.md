---
description: "Retrieves an injected source by means of an index."
title: "IDiaEnumInjectedSources::Item | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumInjectedSources::Item method"
ms.assetid: 14846955-7270-451d-91d2-9cb34bb65187
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaEnumInjectedSources::Item
Retrieves an injected source by means of an index.

## Syntax

```C++
HRESULT Item ( 
   DWORD                index,
   IDiaInjectedSource** injectedSource
);
```

#### Parameters
 index

[in] Index of the [IDiaInjectedSource](../../debugger/debug-interface-access/idiainjectedsource.md) object to be retrieved. The index is the range 0 to `count`-1, where `count` is returned by the [IDiaEnumInjectedSources::get_Count](../../debugger/debug-interface-access/idiaenuminjectedsources-get-count.md) method.

 injectedSource

[out] Returns an [IDiaInjectedSource](../../debugger/debug-interface-access/idiainjectedsource.md) object representing the injected source.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaEnumInjectedSources](../../debugger/debug-interface-access/idiaenuminjectedsources.md)
- [IDiaInjectedSource](../../debugger/debug-interface-access/idiainjectedsource.md)
