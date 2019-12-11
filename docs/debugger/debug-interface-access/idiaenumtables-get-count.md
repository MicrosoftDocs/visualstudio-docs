---
title: "IDiaEnumTables::get_Count | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumTables::get_Count method"
ms.assetid: 30fa316b-a746-4028-acae-4efcd2066f38
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaEnumTables::get_Count
Retrieves the number of tables.

## Syntax

```C++
HRESULT get_Count (    LONG* pRetVal
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