---
description: "Retrieves the memory space kind."
title: "IDiaSymbol::get_memorySpaceKind"
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# `IDiaSymbol::get_memorySpaceKind`

Retrieves the memory space kind.

## Syntax

```C++
HRESULT get_memorySpaceKind(
   DWORD* pRetVal);
```

#### Parameters

 `pRetVal`

[out] A pointer to a `DWORD` that holds the memory space kind. Usually a value from the [`CV_HLSLMemorySpace_e`](../../debugger/debug-interface-access/cv-hlslmemoryspace-e.md) enumeration.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## Remarks

> [!NOTE]
> The newer DXC compiler no longer produces PDBs. This API only has valid values on PDBs produced by the older *fxc.exe* compiler.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`CV_HLSLMemorySpace_e` Enumeration](../../debugger/debug-interface-access/cv-hlslmemoryspace-e.md)
