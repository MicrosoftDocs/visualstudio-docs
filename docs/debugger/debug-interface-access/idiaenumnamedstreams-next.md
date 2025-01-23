---
description: Retrieves the next named stream in the enumeration sequence.
title: "IDiaEnumNamedStreams::Next"
ms.date: "11/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumNamedStreams::Next method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumNamedStreams::Next

Advances to the enumeration and optionally retrieves the name of the next named stream in the enumeration sequence.

## Syntax

```c++
HRESULT Next ( 
   [out, optional] BSTR* pRetVal
);
```

## Parameters

`[out, optional] pRetVal`

Optionally returns the name of the next named stream in this enumeration.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if there are no more named streams. Otherwise, it returns an error code.

## See also

- [`IDiaEnumNamedStreams`](../../debugger/debug-interface-access/idiaenumnamedstreams.md)
