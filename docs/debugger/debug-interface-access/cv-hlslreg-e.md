---
title: CV_HLSLREG_e Enumeration
description: Specifies the HLSL register type kind.
ms.date: "07/15/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "CV_HLSLREG_e enumeration"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# `CV_HLSLREG_e` Enumeration

Specifies the HLSL register type.

## Syntax

```c++
typedef enum CV_HLSLREG_e
{
    CV_HLSLREG_TEMP                                = 0,  
    CV_HLSLREG_INPUT                               = 1,  
    CV_HLSLREG_OUTPUT                              = 2,  
    CV_HLSLREG_INDEXABLE_TEMP                      = 3,  
    CV_HLSLREG_IMMEDIATE32                         = 4,  
    CV_HLSLREG_IMMEDIATE64                         = 5,  
    CV_HLSLREG_SAMPLER                             = 6,  
    CV_HLSLREG_RESOURCE                            = 7,  
    CV_HLSLREG_CONSTANT_BUFFER                     = 8,  
    CV_HLSLREG_IMMEDIATE_CONSTANT_BUFFER           = 9,  
    CV_HLSLREG_LABEL                               = 10, 
    CV_HLSLREG_INPUT_PRIMITIVEID                   = 11, 
    CV_HLSLREG_OUTPUT_DEPTH                        = 12, 
    CV_HLSLREG_NULL                                = 13, 
    CV_HLSLREG_RASTERIZER                          = 14, 
    CV_HLSLREG_OUTPUT_COVERAGE_MASK                = 15, 
    CV_HLSLREG_STREAM                              = 16, 
    CV_HLSLREG_FUNCTION_BODY                       = 17, 
    CV_HLSLREG_FUNCTION_TABLE                      = 18, 
    CV_HLSLREG_INTERFACE                           = 19, 
    CV_HLSLREG_FUNCTION_INPUT                      = 20, 
    CV_HLSLREG_FUNCTION_OUTPUT                     = 21, 
    CV_HLSLREG_OUTPUT_CONTROL_POINT_ID             = 22, 
    CV_HLSLREG_INPUT_FORK_INSTANCE_ID              = 23, 
    CV_HLSLREG_INPUT_JOIN_INSTANCE_ID              = 24, 
    CV_HLSLREG_INPUT_CONTROL_POINT                 = 25, 
    CV_HLSLREG_OUTPUT_CONTROL_POINT                = 26, 
    CV_HLSLREG_INPUT_PATCH_CONSTANT                = 27, 
    CV_HLSLREG_INPUT_DOMAIN_POINT                  = 28, 
    CV_HLSLREG_THIS_POINTER                        = 29, 
    CV_HLSLREG_UNORDERED_ACCESS_VIEW               = 30, 
    CV_HLSLREG_THREAD_GROUP_SHARED_MEMORY          = 31, 
    CV_HLSLREG_INPUT_THREAD_ID                     = 32, 
    CV_HLSLREG_INPUT_THREAD_GROUP_ID               = 33, 
    CV_HLSLREG_INPUT_THREAD_ID_IN_GROUP            = 34, 
    CV_HLSLREG_INPUT_COVERAGE_MASK                 = 35, 
    CV_HLSLREG_INPUT_THREAD_ID_IN_GROUP_FLATTENED  = 36,
    CV_HLSLREG_INPUT_GS_INSTANCE_ID                = 37, 
    CV_HLSLREG_OUTPUT_DEPTH_GREATER_EQUAL          = 38, 
    CV_HLSLREG_OUTPUT_DEPTH_LESS_EQUAL             = 39, 
    CV_HLSLREG_CYCLE_COUNTER                       = 40, 
} CV_HLSLREG_e;
```

## Remarks

Use the [`IDiaSymbol::get_registerType`](../../debugger/debug-interface-access/idiasymbol-get-registertype.md) method to retrieve the register type for an HLSL symbol.

> [!NOTE]
> The newer DXC compiler no longer produces PDBs. This API only has valid values on PDBs produced by the older *fxc.exe* compiler.

## Requirements

Header: cvconst.h

## See also

- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [`IDiaSymbol::get_registerType`](../../debugger/debug-interface-access/idiasymbol-get-registertype.md)
