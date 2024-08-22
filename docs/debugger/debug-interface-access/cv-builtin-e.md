---
title: CV_builtin_e
description: Specifies the HLSL built in type kind.
ms.date: "07/15/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "CV_builtin_e enumeration"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# `CV_builtin_e`

Specifies the HLSL built in type kind.

## Syntax

```c++
typedef enum CV_builtin_e
{
    // 0x0000 - 0x01ff - Reserved.
    CV_BI_INVALID                       = 0x0000,

    // 0x0200 - 0x03ff - HLSL types.

    CV_BI_HLSL_INTERFACE_POINTER        = 0x0200,
    CV_BI_HLSL_TEXTURE1D                = 0x0201,
    CV_BI_HLSL_TEXTURE1D_ARRAY          = 0x0202,
    CV_BI_HLSL_TEXTURE2D                = 0x0203,
    CV_BI_HLSL_TEXTURE2D_ARRAY          = 0x0204,
    CV_BI_HLSL_TEXTURE3D                = 0x0205,
    CV_BI_HLSL_TEXTURECUBE              = 0x0206,
    CV_BI_HLSL_TEXTURECUBE_ARRAY        = 0x0207,
    CV_BI_HLSL_TEXTURE2DMS              = 0x0208,
    CV_BI_HLSL_TEXTURE2DMS_ARRAY        = 0x0209,
    CV_BI_HLSL_SAMPLER                  = 0x020a,
    CV_BI_HLSL_SAMPLERCOMPARISON        = 0x020b,
    CV_BI_HLSL_BUFFER                   = 0x020c,
    CV_BI_HLSL_POINTSTREAM              = 0x020d,
    CV_BI_HLSL_LINESTREAM               = 0x020e,
    CV_BI_HLSL_TRIANGLESTREAM           = 0x020f,
    CV_BI_HLSL_INPUTPATCH               = 0x0210,
    CV_BI_HLSL_OUTPUTPATCH              = 0x0211,
    CV_BI_HLSL_RWTEXTURE1D              = 0x0212,
    CV_BI_HLSL_RWTEXTURE1D_ARRAY        = 0x0213,
    CV_BI_HLSL_RWTEXTURE2D              = 0x0214,
    CV_BI_HLSL_RWTEXTURE2D_ARRAY        = 0x0215,
    CV_BI_HLSL_RWTEXTURE3D              = 0x0216,
    CV_BI_HLSL_RWBUFFER                 = 0x0217,
    CV_BI_HLSL_BYTEADDRESS_BUFFER       = 0x0218,
    CV_BI_HLSL_RWBYTEADDRESS_BUFFER     = 0x0219,
    CV_BI_HLSL_STRUCTURED_BUFFER        = 0x021a,
    CV_BI_HLSL_RWSTRUCTURED_BUFFER      = 0x021b,
    CV_BI_HLSL_APPEND_STRUCTURED_BUFFER = 0x021c,
    CV_BI_HLSL_CONSUME_STRUCTURED_BUFFER= 0x021d,
    CV_BI_HLSL_MIN8FLOAT                = 0x021e,
    CV_BI_HLSL_MIN10FLOAT               = 0x021f,
    CV_BI_HLSL_MIN16FLOAT               = 0x0220,
    CV_BI_HLSL_MIN12INT                 = 0x0221,
    CV_BI_HLSL_MIN16INT                 = 0x0222,
    CV_BI_HLSL_MIN16UINT                = 0x0223,
    CV_BI_HLSL_CONSTANT_BUFFER          = 0x0224,

    // 0x0400 - 0xffff - Unused.

} CV_builtin_e;
```

## Remarks

Use the [`IDiaSymbol::get_builtInKind`](../../debugger/debug-interface-access/idiasymbol-get-builtinkind.md) method to retrieve the built in type kind for a HLSL symbol.

> [!NOTE]
> The newer DXC compiler no longer produces PDBs. This API only has valid values on PDBs produced by the older *fxc.exe* compiler.

## Requirements

Header: cvconst.h

## See also

- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [`IDiaSymbol::get_builtInKind`](../../debugger/debug-interface-access/idiasymbol-get-builtinkind.md)
