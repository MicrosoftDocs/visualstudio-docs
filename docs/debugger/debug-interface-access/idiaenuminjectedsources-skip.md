---
description: Skips a specified number of injected sources in an enumeration sequence.
title: "IDiaEnumInjectedSources::Skip"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumInjectedSources::Skip method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumInjectedSources::Skip

Skips a specified number of injected sources in an enumeration sequence.

## Syntax

```c++
HRESULT Skip ( 
   ULONG celt
);
```

#### Parameters

celt

[in] The number of injected sources in the enumeration sequence to skip.

## Return Value

If successful, returns `S_OK`; otherwise, returns `S_FALSE` if there are no more injected sources to skip.

## See also

- [IDiaEnumInjectedSources](../../debugger/debug-interface-access/idiaenuminjectedsources.md)
