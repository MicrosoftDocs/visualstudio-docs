---
description: Holds a value from SymTagTaggedUnionCase.
title: DiaTagValue
ms.date: "07/15/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "DiaTagValue structure"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# DiaTagValue

Describes the numeric value of a discriminated union's tag.

## Syntax

```c++
struct DiaTagValue {
    BYTE value[16];
    BYTE valueSizeBytes;
};
```

## Elements

| Element | Description                                                 |
| ------- | ----------------------------------------------------------- |
| `value` | The integer value stored in little-endian byte ordering.|
| `valueSizeBytes` | The size in bytes of `value`. Must be one of 1, 2, 4, 8, 16 or 0 if this value is empty.|

## Remarks

A `DiaTagValue` can represent various values relating to discriminated or tagged unions, like Rust's enum variants.

An alternative way to think of a `DiaTagValue` could be something like this:

```c++
struct DiaTagValue {
    union {
        uint8_t data8;
        uint16_t data16;
        uint32_t data32;
        uint64_t data64;
        uint128_t data128;
    } value;
    uint8_t valueSizeBytes;
};
```

## Requirements

Header: dia2.h

## See also

- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [IDiaSymbol11](../../debugger/debug-interface-access/idiasymbol11.md)
