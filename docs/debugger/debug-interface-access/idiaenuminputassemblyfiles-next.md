---
description: Retrieves a specified number of input assembly files in the enumeration sequence.
title: "IDiaEnumInputAssemblyFiles::Next"
ms.date: "7/2/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumInputAssemblyFiles::Next method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumInputAssemblyFiles::Next

Retrieves a specified number of input assembly files in the enumeration sequence.

## Syntax

```c++
HRESULT Next ( 
   ULONG                   celt,
   IDiaInputAssemblyFile** rgelt,
   ULONG*                  pceltFetched
);
```

#### Parameters

`celt`

[in] The number of injected sources in the enumerator to be retrieved.

`rgelt`

[out] Returns an array of [`IDiaInputAssemblyFile`](../../debugger/debug-interface-access/idiainputassemblyfile.md) objects that represents the desired input assembly files.

`pceltFetched`

[out] Returns the number of input assembly files in the fetched enumerator.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if there are no more input assembly files. Otherwise, returns an error code.

## See also

- [`IDiaEnumInputAssemblyFiles`](../../debugger/debug-interface-access/idiaenuminputassemblyfiles.md)
- [`IDiaInputAssemblyFile`](../../debugger/debug-interface-access/idiainputassemblyfile.md)
