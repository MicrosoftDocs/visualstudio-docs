---
description: Retrieves the number of named streams.
title: "IDiaEnumNamedStreamss::get_Count"
ms.date: "11/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumNamedStreams::get_Count method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumNamedStreams::get_Count

Retrieves the number of named streams retrieved by this enumerator.

## Syntax

```c++
HRESULT get_Count ( 
   [out] LONG* pRetVal
);
```

## Parameters

`[out] pRetVal`

Returns the number of named streams in this enumeration.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaEnumNamedStreams`](../../debugger/debug-interface-access/idiaenumnamedstreams.md)
