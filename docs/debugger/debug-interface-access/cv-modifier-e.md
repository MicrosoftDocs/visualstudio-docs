---
title: CV_modifier_e
description: Get information about the CV_modifier_e enumeration type, which specifies the modifiers of types in the debug interface access SDK.
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "CV_modifier_e enumeration"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# CV_modifier_e

Specifies the modifiers of types.

## Syntax

```c++
typedef enum CV_modifier_e
{
    CV_MOD_INVALID                      = 0x0000,

    // Standard modifiers.

    CV_MOD_CONST                        = 0x0001,
    CV_MOD_VOLATILE                     = 0x0002,
    CV_MOD_UNALIGNED                    = 0x0003,

    // HLSL modifiers.

    CV_MOD_HLSL_UNIFORM                 = 0x0200,
    CV_MOD_HLSL_LINE                    = 0x0201,
    CV_MOD_HLSL_TRIANGLE                = 0x0202,
    CV_MOD_HLSL_LINEADJ                 = 0x0203,
    CV_MOD_HLSL_TRIANGLEADJ             = 0x0204,
    CV_MOD_HLSL_LINEAR                  = 0x0205,
    CV_MOD_HLSL_CENTROID                = 0x0206,
    CV_MOD_HLSL_CONSTINTERP             = 0x0207,
    CV_MOD_HLSL_NOPERSPECTIVE           = 0x0208,
    CV_MOD_HLSL_SAMPLE                  = 0x0209,
    CV_MOD_HLSL_CENTER                  = 0x020a,
    CV_MOD_HLSL_SNORM                   = 0x020b,
    CV_MOD_HLSL_UNORM                   = 0x020c,
    CV_MOD_HLSL_PRECISE                 = 0x020d,
    CV_MOD_HLSL_UAV_GLOBALLY_COHERENT   = 0x020e,

} CV_modifier_e;
```

## Elements

| Element      | Description                  |
| ------------ | ---------------------------- |
| `CV_MOD_INVALID` | Invalid modifier (unused) |
| `CV_MOD_CONST` | C++ `const` |
| `CV_MOD_VOLATILE` | C++ `volatile` |
| `CV_MOD_UNALIGNED` | C++ `__unaligned` |
| `CV_MOD_HLSL_UNIFORM` | HLSL uniform |
| `CV_MOD_HLSL_LINE` | HLSL line |
| `CV_MOD_HLSL_TRIANGLE` | HLSL triangle |
| `CV_MOD_HLSL_LINEADJ` | HLSL lineadj |
| `CV_MOD_HLSL_TRIANGLEADJ` | HLSL triangeadj |
| `CV_MOD_HLSL_LINEAR` | HLSL linear |
| `CV_MOD_HLSL_CENTROID` | HLSL centroid |
| `CV_MOD_HLSL_CONSTINTERP` | HLSL constinterp |
| `CV_MOD_HLSL_NOPERSPECTIVE` | HLSL noperspective |
| `CV_MOD_HLSL_SAMPLE` | HLSL sample |
| `CV_MOD_HLSL_CENTER` | HLSL center |
| `CV_MOD_HLSL_SNORM` | HLSL snorm |
| `CV_MOD_HLSL_UNORM` | HLSL unorm |
| `CV_MOD_HLSL_PRECISE` | HLSL precise |
| `CV_MOD_HLSL_UAV_GLOBALLY_COHERENT` | HLSL UAV globally coherent |

## Remarks

> [!NOTE]
> The newer DXC compiler no longer produces PDBs. The HLSL elements only have valid values on PDBs produced by the older *fxc.exe* compiler.

## Requirements

Header: cvconst.h

## See also

- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [IDiaSymbol::get_modifierValues](../../debugger/debug-interface-access/idiasymbol-get-modifiervalues.md)
