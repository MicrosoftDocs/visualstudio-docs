---
description: Retrieves a flag that indicates whether the PDB was available at the creation of the .NET Native binary.
title: "IDiaInputAssemblyFile::get_pdbAvailableAtILMerge"
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaInputAssemblyFile::get_pdbAvailableAtILMerge method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaInputAssemblyFile::get_pdbAvailableAtILMerge

Retrieves a flag that indicates whether the PDB was available at the creation of the .NET Native binary.

## Syntax

```C++
HRESULT get_pdbAvailableAtILMerge(
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the `TRUE` if the PDB was available at the creation of the .NET Native binary; otherwise, returns `FALSE`.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaInputAssemblyFile`](../../debugger/debug-interface-access/idiainputassemblyfile.md)
- [Compile apps with .NET Native](/windows/uwp/dotnet-native/)
