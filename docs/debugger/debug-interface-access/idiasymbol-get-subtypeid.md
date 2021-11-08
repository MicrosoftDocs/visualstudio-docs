---
description: "Retrieves the sub type ID."
title: "IDiaSymbol::get_subTypeId | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
ms.assetid: 0f899920-4fc5-4de8-84a3-cd98c57bf124
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_subTypeId
Retrieves the sub type ID.

## Syntax

```C++
HRESULT get_subTypeId(
   DWORD* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `DWORD` that holds the sub type ID.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
