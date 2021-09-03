---
description: "Describes the variety of user-defined type (UDT)."
title: "UdtKind | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "UdtKind enumeration"
ms.assetid: 400b59b9-373c-42cb-aae1-570494214328
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# UdtKind
Describes the variety of user-defined type (UDT).

## Syntax

```C++
enum UdtKind {
    UdtStruct,
    UdtClass,
    UdtUnion,
    UdtInterface
};
```

## Elements
UdtStruct
UDT is a structure.

UdtClass
UDT is a class.

UdtUnion
UDT is a union.

UdtInterface
UDT is an interface.

## Remarks
The values in this enumeration are returned by the [IDiaSymbol::get_udtKind](../../debugger/debug-interface-access/idiasymbol-get-udtkind.md) method.

## Requirements
Header: cvconst.h

## See also
- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [IDiaSymbol::get_udtKind](../../debugger/debug-interface-access/idiasymbol-get-udtkind.md)
