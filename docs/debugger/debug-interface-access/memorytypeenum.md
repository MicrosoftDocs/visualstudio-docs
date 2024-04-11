---
description: "Specifies the type of memory to access."
title: "MemoryTypeEnum"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "MemoryTypeEnum enumeration"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# MemoryTypeEnum

Specifies the type of memory to access.

## Syntax

```C++
enum MemoryTypeEnum {
    MemTypeCode,
    MemTypeData,
    MemTypeStack,
    MemTypeAny = -1
};
```

## Elements

| Element        | Description                    |
| -------------- | ------------------------------ |
| `MemTypeCode`  | Accesses only code memory.     |
| `MemTypeData`  | Accesses data or stack memory. |
| `MemTypeStack` | Accesses only stack memory.    |
| `MemTypeAny`   | Accesses any kind of memory.   |

## Remarks
The values in this enumeration are passed to the [IDiaStackWalkHelper::readMemory](../../debugger/debug-interface-access/idiastackwalkhelper-readmemory.md) method to limit access to different types of memory.

## Requirements
Header: cvconst.h

## See also
- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [IDiaStackWalkHelper::readMemory](../../debugger/debug-interface-access/idiastackwalkhelper-readmemory.md)
