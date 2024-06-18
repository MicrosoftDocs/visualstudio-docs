---
description: Retrieves a specified number of tables in the enumeration sequence.
title: "IDiaEnumTables::Next"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumTables::Next method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumTables::Next

Retrieves a specified number of tables in the enumeration sequence.

## Syntax

```c++
HRESULT Next ( 
   ULONG       celt,
   IDiaTable** rgelt,
   ULONG*      pceltFetched
);
```

#### Parameters

 `celt`

[in] The number of tables in the enumerator to be retrieved.

 `rgelt`

[out] An array that is to be filled in with the [IDiaTable](../../debugger/debug-interface-access/idiatable.md) objects that represent the desired tables.

 `pceltFetched`

[out] Returns the number of tables in the fetched enumerator.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if there are no more tables. Otherwise, returns an error code.

## See also

- [IDiaEnumTables](../../debugger/debug-interface-access/idiaenumtables.md)
- [IDiaTable](../../debugger/debug-interface-access/idiatable.md)
