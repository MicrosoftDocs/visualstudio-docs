---
title: "IDiaSymbol::get_targetOffset | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_targetOffset method"
ms.assetid: 7d141223-132a-409c-a5a4-94f97340313c
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_targetOffset
Retrieves the offset section of a thunk target.

## Syntax

```C++
HRESULT get_targetOffset ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the offset part of a thunk target address.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)