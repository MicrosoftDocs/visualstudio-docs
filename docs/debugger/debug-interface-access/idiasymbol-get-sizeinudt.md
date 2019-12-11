---
title: "IDiaSymbol::get_sizeInUdt | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
ms.assetid: a82ab896-0185-46a4-b4d5-babfcc660fe1
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_sizeInUdt
Retrieves the size of a member of a user-defined type.

## Syntax

```C++
HRESULT get_sizeInUdt(
   DWORD* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `DWORD` that specifies the size of the member.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)