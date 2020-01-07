---
title: "IDiaEnumInjectedSources::Next | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumInjectedSources::Next method"
ms.assetid: 38af80fc-748f-4b15-bff1-823db21dd4d0
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaEnumInjectedSources::Next
Retrieves a specified number of injected sources in the enumeration sequence.

## Syntax

```C++
HRESULT Next ( 
   ULONG                celt,
   IDiaInjectedSource** rgelt,
   ULONG*               pceltFetched
);
```

#### Parameters
 celt

[in] The number of injected sources in the enumerator to be retrieved.

 rgelt

[out] Returns an array of [IDiaInjectedSource](../../debugger/debug-interface-access/idiainjectedsource.md) objects that represents the desired injected sources.

 pceltFetched

[out] Returns the number of injected sources in the fetched enumerator.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if there are no more injected sources. Otherwise, returns an error code.

## See also
- [IDiaEnumInjectedSources](../../debugger/debug-interface-access/idiaenuminjectedsources.md)
- [IDiaInjectedSource](../../debugger/debug-interface-access/idiainjectedsource.md)