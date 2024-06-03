---
description: Creates an enumerator that contains the same enumeration state as the current tables enumerator.
title: "IDiaEnumTables::Clone"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumTables::Clone method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumTables::Clone

Creates an enumerator that contains the same enumeration state as the current enumerator.

## Syntax

```c++
HRESULT Clone ( 
   IDiaEnumTables** ppenum
);
```

#### Parameters

 `ppenum`

[out] Returns an [IDiaEnumTables](../../debugger/debug-interface-access/idiaenumtables.md) object that contains a duplicate of the enumerator. The tables are not duplicated, only the enumerator.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [IDiaEnumTables](../../debugger/debug-interface-access/idiaenumtables.md)
