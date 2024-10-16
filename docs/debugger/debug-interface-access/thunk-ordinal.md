---
description: "Designates thunk types."
title: "THUNK_ORDINAL"
ms.date: "07/22/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "Thunk_Ordinal enumeration"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# `THUNK_ORDINAL`

Designates thunk types.

## Syntax

```C++
typedef enum THUNK_ORDINAL {
    THUNK_ORDINAL_NOTYPE,
    THUNK_ORDINAL_ADJUSTOR,
    THUNK_ORDINAL_VCALL,
    THUNK_ORDINAL_PCODE,
    THUNK_ORDINAL_LOAD

    // trampoline thunk ordinals - only for use in Trampoline thunk symbols
    THUNK_ORDINAL_TRAMP_INCREMENTAL,
    THUNK_ORDINAL_TRAMP_BRANCHISLAND,
    THUNK_ORDINAL_TRAMP_STRICTICF,
    THUNK_ORDINAL_TRAMP_ARM64XSAMEADDRESS,
    THUNK_ORDINAL_TRAMP_FUNCOVERRIDING,
} THUNK_ORDINAL;
```

## Elements

| Element                          | Description                                                                                                 |
| -------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `THUNK_ORDINAL_NOTYPE`             | Standard thunk.                                                                                             |
| `THUNK_ORDINAL_ADJUSTOR`           | A `this` adjustor thunk.                                                                                    |
| `THUNK_ORDINAL_VCALL`              | Virtual call thunk.                                                                                         |
| `THUNK_ORDINAL_PCODE`              | P-code thunk.                                                                                               |
| `THUNK_ORDINAL_LOAD`               | Delay load thunk.                                                                                           |
| `THUNK_ORDINAL_TRAMP_INCREMENTAL`  | Incremental trampoline thunk (a trampoline thunk is used to bounce calls from one memory space to another). |
| `THUNK_ORDINAL_TRAMP_BRANCHISLAND` | Branch point trampoline thunk.                                                                              |
| `THUNK_ORDINAL_TRAMP_STRICTICF`    | Strict icf trampoline thunk. |
| `THUNK_ORDINAL_TRAMP_ARM64XSAMEADDRESS` | ARM64X same address trampoline thunk. |
| `THUNK_ORDINAL_TRAMP_FUNCOVERRIDING` | Function overriding trampoline thunk. |


## Remarks

The values in this enumeration are returned from a call to the [IDiaSymbol::get_thunkOrdinal](../../debugger/debug-interface-access/idiasymbol-get-thunkordinal.md) method.

## Requirements

Header: cvconst.h

## See also

- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [`IDiaSymbol::get_thunkOrdinal`](../../debugger/debug-interface-access/idiasymbol-get-thunkordinal.md)
