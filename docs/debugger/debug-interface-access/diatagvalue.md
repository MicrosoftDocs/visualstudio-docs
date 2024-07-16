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

Describes an entry in an address map.

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
| `valueSizeBytes` | The size in bytes of `value`. Must be one of 1, 2, 4, 8, or 16.|

## Remarks

A `DiaTagValue` can represent various values relating to discriminated or tagged unions, like Rust's enum variants.

An alternative way to think of a `DiaTagValue` could be something like this:

```c++
struct DiaTagValue {
    union {
        uint8 data8;
        uint16 data16;
        uint32 data32;
        uint64 data64;
        uint128 data128;
    } value;
    BYTE valueSizeBytes;
};
```

## Requirements

Header: dia2.h

## See also

- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [IDiaSymbol11](../../debugger/debug-interface-access/idiasymbol11.md)
