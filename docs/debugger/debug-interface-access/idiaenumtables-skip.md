---
description: Skips a specified number of tables in an enumeration sequence.
title: "IDiaEnumTables::Skip"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumTables::Skip method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumTables::Skip

Skips a specified number of tables in an enumeration sequence.

## Syntax

```c++
HRESULT Skip ( 
   ULONG celt
);
```

#### Parameters

 `celt`

[in] The number of tables in the enumeration sequence to skip.

## Return Value

If successful, returns `S_OK`; otherwise, returns `S_FALSE` if there are no more tables to skip.

## See also

- [IDiaEnumTables](../../debugger/debug-interface-access/idiaenumtables.md)
