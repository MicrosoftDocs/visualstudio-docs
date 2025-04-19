---
description: Skips a specified number of input assembly files in an enumeration sequence.
title: "IDiaEnumInputAssemblyFiles::Skip"
ms.date: "7/2/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumInputAssemblyFiles::Skip method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumInputAssemblyFiles::Skip

Skips a specified number of input assembly files in an enumeration sequence.

## Syntax

```c++
HRESULT Skip ( 
   ULONG celt
);
```

#### Parameters

`celt`

[in] The number of input assembly files in the enumeration sequence to skip.

## Return Value

If successful, returns `S_OK`; otherwise, returns `S_FALSE` if there are no more injected sources to skip.

## See also

- [`IDiaEnumInputAssemblyFiles`](../../debugger/debug-interface-access/idiaenuminputassemblyfiles.md)
