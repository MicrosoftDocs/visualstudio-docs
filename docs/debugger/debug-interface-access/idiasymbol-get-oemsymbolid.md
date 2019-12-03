---
title: "IDiaSymbol::get_oemSymbolId | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_oemSymbolId method"
ms.assetid: 187801f0-bd82-4c5b-9fae-8eeb1a4ac0ce
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_oemSymbolId
Retrieves the original equipment manufacturer (OEM) symbol's ID value.

## Syntax

```C++
HRESULT get_oemSymbolId ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns an OEM's internally assigned symbol ID.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 The identifier is a unique value created by the DIA SDK to mark all symbols as unique.

 This property applies only to symbols with a [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) type of `SymTagCustomType`.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md)