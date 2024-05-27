---
description: Creates an enumerator that contains the same enumeration state as the current enumerator.
title: "IDiaEnumSegments::Clone"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSegments::Clone method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumSegments::Clone

Creates an enumerator that contains the same enumeration state as the current enumerator.

## Syntax

```c++
HRESULT Clone ( 
   IDiaEnumSegments** ppenum
);
```

#### Parameters

ppenum

[out] Returns an [IDiaEnumSegments](../../debugger/debug-interface-access/idiaenumsegments.md) object that contains a duplicate of the enumerator. The segments are not duplicated, only the enumerator.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [IDiaEnumSegments](../../debugger/debug-interface-access/idiaenumsegments.md)
