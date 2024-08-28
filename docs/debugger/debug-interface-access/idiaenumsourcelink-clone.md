---
description: Creates an enumerator that contains the same enumeration state as the current source enumerator.
title: "IDiaEnumSourceLink::Clone"
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSourceLink::Clone method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaEnumSourceLink::Clone

Creates an enumerator that contains the same enumeration state as the current enumerator.

## Syntax

```c++
HRESULT Clone(
   IDiaEnumSourceLink** ppenum
);
```

#### Parameters

 `ppenum`

[out] Returns an [`IDiaEnumSourceLink`](../../debugger/debug-interface-access/idiaenumsourcelink.md) object that contains a duplicate of the enumerator. The source link blobs are not duplicated, only the enumerator.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaEnumSourceLink`](../../debugger/debug-interface-access/idiaenumsourcelink.md)
