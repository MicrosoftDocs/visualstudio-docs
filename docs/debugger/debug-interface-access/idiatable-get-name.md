---
description: "Retrieves the name of the table."
title: "IDiaTable::get_name | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaTable::get_name method"
ms.assetid: f6e9cd07-63cd-48a6-9835-e69c2d0859c5
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaTable::get_name
Retrieves the name of the table.

## Syntax

```C++
HRESULT get_name ( 
   BSTR* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the name of the table.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaTable](../../debugger/debug-interface-access/idiatable.md)
