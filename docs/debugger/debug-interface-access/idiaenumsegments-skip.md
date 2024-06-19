---
description: Skips a specified number of segments in an enumeration sequence.
title: "IDiaEnumSegments::Skip"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSegments::Skip method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumSegments::Skip

Skips a specified number of segments in an enumeration sequence.

## Syntax

```c++
HRESULT Skip ( 
   ULONG celt
);
```

#### Parameters

celt

[in] The number of segments in the enumeration sequence to skip.

## Return Value

If successful, returns `S_OK`; otherwise, returns `S_FALSE` if there are no more segments to skip.

## See also

- [IDiaEnumSegments](../../debugger/debug-interface-access/idiaenumsegments.md)
