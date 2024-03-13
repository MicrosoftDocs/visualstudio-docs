---
description: "Retrieves the size of a member of a user-defined type."
title: "IDiaSymbol::get_sizeInUdt"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
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
