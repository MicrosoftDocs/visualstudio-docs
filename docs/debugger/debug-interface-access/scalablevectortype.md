---
title: ScalableVectorType Enumeration
description: Defines the types of scalable vector registers used in ARM Scalable Vector Extension (SVE) architecture.
ms.date: 12/09/2025
ms.topic: "reference"
f1_keywords:
  - ScalableVectorType
helpviewer_keywords:
  - ScalableVectorType enumeration
  - SVE_Z
  - SVE_P
  - SVE_FFR
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# ScalableVectorType

Defines types of scalable vector registers used in the ARM Scalable Vector Extension (SVE) architecture. These registers enable advanced SIMD operations for high-performance computing on ARM processors.

## Syntax

```cpp
enum ScalableVectorType
{
    SVE_NONE = 0,   // Not a scalable vector type
    SVE_Z = 1,      // SVE Z (data) registers
    SVE_P = 2,      // SVE P (predicate) registers
    // Reserved for future scalable vector types
};
```

## Elements

| Name      | Value | Description                                            |
|-----------|-------|--------------------------------------------------------|
| SVE_NONE  | 2     | Not a scalable vector type.                            |
| SVE_Z     | 0     | Represents scalable vector Z data register (SVE_Z).    |
| SVE_P     | 1     | Represents scalable vector predicate register (SVE_P). |

## Remarks

The `ScalableVectorType` enumeration defines the types of scalable vector registers used in ARM Scalable Vector Extension (SVE) architecture. These registers are utilized for advanced SIMD operations in modern ARM processors.

## Requirements

Header: cvconst.h

## See also

- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [IDiaSymbol12](../../debugger/debug-interface-access/idiasymbol12.md)
