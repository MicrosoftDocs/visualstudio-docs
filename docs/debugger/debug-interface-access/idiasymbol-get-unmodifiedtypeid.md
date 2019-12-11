---
title: "IDiaSymbol::get_unmodifiedTypeId | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
ms.assetid: 4f7fc73c-f524-4d7a-b378-a9ab99a96104
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_unmodifiedTypeId
Retrieves the ID of the original (unmodified) type.

## Syntax

```C++
HRESULT get_unmodifiedTypeId(
   DWORD* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `DWORD` that holds the ID.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)