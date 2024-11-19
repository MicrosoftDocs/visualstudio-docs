---
description: Advances a specified number of names in the enumeration sequence.
title: "IDiaEnumNamedStreams::Skip"
ms.date: "11/19/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumNamedStreams::Skip method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumNamedStreams::Skip

Advances a specified number of names in the enumeration sequence.

## Syntax

```c++
HRESULT Skip ( 
   [in] ULONG celt
);
```

## Parameters

`[in] celt`

The number of names in the enumeration sequence to skip. 

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if there are no more named streams. Otherwise, it returns an error code.

## See also

- [`IDiaEnumNamedStreams`](../../debugger/debug-interface-access/idiaenumnamedstreams.md)
