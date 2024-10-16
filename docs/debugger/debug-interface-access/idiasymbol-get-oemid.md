---
description: "Retrieves the symbol's original equipment manufacturer (OEM) ID value."
title: "IDiaSymbol::get_oemId"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_oemId method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_oemId

Retrieves the symbol's original equipment manufacturer (OEM) ID value.

## Syntax

```C++
HRESULT get_oemId ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns a unique value that identifies an OEM.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Remarks
 This property applies only to symbols with a [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) type of `SymTagCustomType`.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md)
