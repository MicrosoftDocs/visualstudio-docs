---
description: Retrieves the size of the next source link blob, without advancing the enumeration. Method of IDiaEnumSourceLink2.
title: "IDiaEnumSourceLink2::SizeOfNext2"
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSourceLink2::SizeOfNext2 method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaEnumSourceLink2::SizeOfNext2

Retrieves the size of the next source link blob, without advancing the enumeration.

## Syntax

```c++
HRESULT SizeOfNext(
   ULONGLONG* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the size of the next source link blob.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaEnumSourceLink2`](../../debugger/debug-interface-access/idiaenumsourcelink2.md)
- [`IDiaEnumSourceLink::SizeOfNext`](../../debugger/debug-interface-access/idiaenumsourcelink-sizeofnext.md)
