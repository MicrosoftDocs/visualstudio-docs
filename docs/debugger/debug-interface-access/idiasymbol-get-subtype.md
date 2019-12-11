---
title: "IDiaSymbol::get_subType | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
ms.assetid: 0b3cbf77-8f11-434a-ad60-ea9829fec6fa
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_subType
Retrieves the sub type.

## Syntax

```C++
HRESULT get_subType(
   IDiaSymbol** pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to the sub type.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)