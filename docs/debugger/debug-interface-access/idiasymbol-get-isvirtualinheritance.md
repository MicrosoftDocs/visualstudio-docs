---
title: "IDiaSymbol::get_isVirtualInheritance | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
ms.assetid: 72906b92-dd4a-42e3-9b24-b77628fa48c1
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_isVirtualInheritance
Specifies whether the `this` pointer points to a data member with virtual inheritance.

## Syntax

```C++
HRESULT get_isVirtualInheritance(
   BOOL* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `BOOL` that specifies whether the `this` pointer points to a data member with virtual inheritance.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)