---
description: Retrieves a list of sources that has been placed into the symbol store by attribute providers or other components of the compilation process.
title: "IDiaSession::findInjectedSource"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::findInjectedSource method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSession::findInjectedSource

Retrieves a list of sources that has been placed into the symbol store by attribute providers or other components of the compilation process.

## Syntax

```C++
HRESULT findInjectedSource ( 
   LPCOLESTR                 srcFile,
   IDiaEnumInjectedSources** ppResult
);
```

#### Parameters
 srcFile

[in] Name of the source file for which to search.

 ppResult

[out] Returns an [IDiaEnumInjectedSources](../../debugger/debug-interface-access/idiaenuminjectedsources.md) object that contains a list of all of the injected sources.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaEnumInjectedSources](../../debugger/debug-interface-access/idiaenuminjectedsources.md)
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
