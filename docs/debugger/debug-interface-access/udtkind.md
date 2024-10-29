---
description: "Describes the variety of user-defined type (UDT)."
title: "UdtKind"
ms.date: "07/22/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "UdtKind enumeration"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# UdtKind

Describes the variety of user-defined type (UDT).

## Syntax

```C++
enum UdtKind
{
    UdtStruct,
    UdtClass,
    UdtUnion,
    UdtInterface,
    UdtTaggedUnion
};
```

## Elements

| Element      | Description          |
| ------------ | -------------------- |
| UdtStruct    | UDT is a structure.  |
| UdtClass     | UDT is a class.      |
| UdtUnion     | UDT is a union.      |
| UdtInterface | UDT is an interface. |
| UdtTaggedUnion | UDT is a tagged union. |

## Remarks
The values in this enumeration are returned by the [IDiaSymbol::get_udtKind](../../debugger/debug-interface-access/idiasymbol-get-udtkind.md) method.

## Requirements
Header: cvconst.h

## See also
- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [IDiaSymbol::get_udtKind](../../debugger/debug-interface-access/idiasymbol-get-udtkind.md)
