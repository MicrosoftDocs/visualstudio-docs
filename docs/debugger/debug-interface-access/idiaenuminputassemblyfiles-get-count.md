---
description: Retrieves the number of input assembly files.
title: "IDiaEnumInputAssemblyFiles::get_Count"
ms.date: "7/2/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumInputAssemblyFiles::get_Count method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumInputAssemblyFiles::get_Count

Retrieves the number of input assembly files.

## Syntax

```c++
HRESULT get_Count ( 
   LONG* pRetVal
);
```

#### Parameters

`pRetVal`

[out] Returns the number of injected sources.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaEnumInputAssemblyFiles`](../../debugger/debug-interface-access/idiaenuminputassemblyfiles.md)
- [`IDiaEnumInputAssemblyFiles::Item`](../../debugger/debug-interface-access/idiaenuminputassemblyfiles-item.md)
