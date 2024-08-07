---
description: "Specifies the type of memory to access."
title: "MemoryTypeEnum"
ms.date: "07/18/2024"
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
# `MemoryTypeEnum`

Specifies the type of memory to access.

## Syntax

```C++
enum MemoryTypeEnum {
    MemTypeCode,
    MemTypeData,
    MemTypeStack,
    MemTypeCodeOnHeap,              // Read only memory for code generated on heap by runtime
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
| `MemTypeCodeOnHeap` | Accesses only code memory generated on heap by runtime. |

## Remarks
The values in this enumeration are passed to the [`IDiaStackWalkHelper::readMemory`](../../debugger/debug-interface-access/idiastackwalkhelper-readmemory.md) method to limit access to different types of memory.

## Requirements
Header: cvconst.h

## See also
- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [IDiaStackWalkHelper::readMemory](../../debugger/debug-interface-access/idiastackwalkhelper-readmemory.md)
