---
description: "Specifies whether this symbol is a pointer to a data member."
title: "IDiaSymbol::get_isPointerToDataMember | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
ms.assetid: ef17c737-242e-43e8-b7e1-2c3bc58cfcef
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_isPointerToDataMember
Specifies whether this symbol is a pointer to a data member.

## Syntax

```C++
HRESULT get_isPointerToDataMember(
   BOOL* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `BOOL` that specifies whether this symbol is a pointer to a data member.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
