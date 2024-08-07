---
title: CV_HLSLMemorySpace_e Enumeration
description: Specifies the HLSL memory space kind.
ms.date: "07/15/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "CV_HLSLMemorySpace_e enumeration"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# `CV_HLSLMemorySpace_e` Enumeration

Specifies the HLSL memory space kind.

## Syntax

```c++
typedef enum CV_HLSLMemorySpace_e
{
    // HLSL specific memory spaces

    CV_HLSL_MEMSPACE_DATA         = 0x00,
    CV_HLSL_MEMSPACE_SAMPLER      = 0x01,
    CV_HLSL_MEMSPACE_RESOURCE     = 0x02,
    CV_HLSL_MEMSPACE_RWRESOURCE   = 0x03,

    CV_HLSL_MEMSPACE_MAX          = 0x0F,
} CV_HLSLMemorySpace_e;
```

## Remarks

Use the [`IDiaSymbol::get_memorySpaceKind`](../../debugger/debug-interface-access/idiasymbol-get-memoryspacekind.md) method to retrieve the memory space kind for an HLSL symbol.

> [!NOTE]
> The newer DXC compiler no longer produces PDBs. This API only has valid values on PDBs produced by the older *fxc.exe* compiler.

## Requirements

Header: cvconst.h

## See also

- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [`IDiaSymbol::get_memorySpaceKind`](../../debugger/debug-interface-access/idiasymbol-get-memoryspacekind.md)
