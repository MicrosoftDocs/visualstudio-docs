---
title: "IDiaEnumTables::Skip | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumTables::Skip method"
ms.assetid: 5c9db956-0654-4f1a-8775-530aa980d8ec
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaEnumTables::Skip
Skips a specified number of tables in an enumeration sequence.

## Syntax

```C++
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