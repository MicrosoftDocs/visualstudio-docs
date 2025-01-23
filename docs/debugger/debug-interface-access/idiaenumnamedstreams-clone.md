---
description: Creates a new enumerator that contains the same enumeration state as the current enumerator.
title: "IDiaEnumNamedStreams::Clone"
ms.date: "11/19/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumNamedStreams::Clone method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumNamedStreams::Clone

Creates a new enumerator that contains the same enumeration state as the current enumerator.

## Syntax

```c++
HRESULT Clone (
    [out] IDiaEnumNamedStreams** ppEnum
);
```

## Parameters

`[out] ppEnum`

Returns an [`IDiaEnumNamedStreams`](../../debugger/debug-interface-access/idiaenumnamedstreams.md) object that contains a duplicate of this enumerator. The named streams aren't duplicated, only the enumerator.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaEnumNamedStreams`](../../debugger/debug-interface-access/idiaenumnamedstreams.md)
