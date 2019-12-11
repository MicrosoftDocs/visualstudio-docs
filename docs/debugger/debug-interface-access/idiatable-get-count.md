---
title: "IDiaTable::get_Count | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaTable::get_Count method"
ms.assetid: bb47abe8-6706-4679-bc52-79f6444dae7e
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaTable::get_Count
Retrieves the number of items in the table.

## Syntax

```C++
HRESULT get_Count ( 
   LONG* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the number of items in the table.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaTable](../../debugger/debug-interface-access/idiatable.md)
- [IDiaTable::Item](../../debugger/debug-interface-access/idiatable-item.md)