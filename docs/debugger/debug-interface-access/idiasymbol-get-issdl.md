---
title: "IDiaSymbol::get_isSdl | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
ms.assetid: 6aa0e116-da75-4643-a4d7-d8e142231e21
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_isSdl
Specifies whether the module is compiled with the /SDL option.

## Syntax

```C++
HRESULT get_isSdl(
   BOOL *pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `BOOL` that specifies whether the module is compiled with the /SDL option.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)