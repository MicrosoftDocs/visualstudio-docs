---
title: "IDiaSymbol::get_numberOfRegisterIndices | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
ms.assetid: 1ec8b8ea-e423-4327-8dc0-a390e6e3ffb0
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_numberOfRegisterIndices
Retrieves the number of register indices.

## Syntax

```C++
HRESULT get_numberOfRegisterIndices(
   DWORD* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `DWORD` that holds the number of register indices.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)