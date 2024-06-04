---
description: Retrieves the number of tables.
title: "IDiaEnumTables::get_Count"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumTables::get_Count method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumTables::get_Count

Retrieves the number of tables.

## Syntax

```c++
HRESULT get_Count (    LONG* pRetVal
);

```

#### Parameters

 `pRetVal`

[out] Returns the number of tables.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [IDiaEnumTables](../../debugger/debug-interface-access/idiaenumtables.md)
- [IDiaEnumTables::Item](../../debugger/debug-interface-access/idiaenumtables-item.md)
