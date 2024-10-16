---
description: "Retrieves the symbol type classifier."
title: "IDiaSymbol::get_symTag"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_symTag method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_symTag

Retrieves the symbol type classifier.

## Syntax

```C++
HRESULT get_symTag ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns A value from the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) enumeration that specifies the symbol type classifier.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Example

```C++
IDiaSymbol* pType;
DWORD       tag = 0;
pType->get_symTag( &tag );
```

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md)
