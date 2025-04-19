---
description: Retrieves the size of the next source link blob, without advancing the enumeration.
title: "IDiaEnumSourceLink::SizeOfNext"
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSourceLink::SizeOfNext method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaEnumSourceLink::SizeOfNext

Retrieves the size of the next source link blob, without advancing the enumeration.

## Syntax

```c++
HRESULT SizeOfNext(
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the size of the next source link blob.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaEnumSourceLink`](../../debugger/debug-interface-access/idiaenumsourcelink.md)
- [`IDiaEnumSourceLink2::SizeOfNext2`](../../debugger/debug-interface-access/idiaenumsourcelink2-sizeofnext2.md)
