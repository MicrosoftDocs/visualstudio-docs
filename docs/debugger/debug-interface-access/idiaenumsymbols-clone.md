---
description: Creates an enumerator that contains the same enumeration state as the current symbols enumerator.
title: "IDiaEnumSymbols::Clone"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSymbols::Clone method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumSymbols::Clone

Creates an enumerator that contains the same enumeration state as the current enumerator.

## Syntax

```c++
HRESULT Clone ( 
   IDiaEnumSymbols** ppenum
);
```

#### Parameters

ppenum

[out] Returns an [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md) object that contains a duplicate of the enumerator. The symbols are not duplicated, only the enumerator.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md)
