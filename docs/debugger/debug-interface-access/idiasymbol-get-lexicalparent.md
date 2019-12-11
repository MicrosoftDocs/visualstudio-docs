---
title: "IDiaSymbol::get_lexicalParent | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_lexicalParent method"
ms.assetid: 4d119965-33a8-474c-9c64-95c5218c389c
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_lexicalParent
Retrieves a reference to the lexical parent of the symbol.

## Syntax

```C++
HRESULT get_lexicalParent ( 
   IDiaSymbol** pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object that represents the lexical parent of the symbol.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 The lexical parent of a symbol is the enclosing function or module. For example, the lexical parent of a function parameter or local variable is the function itself while the lexical parent of the function is the module it is defined in.

 The possible symbols that can appear as lexical parents are documented in [Lexical Hierarchy of Symbol Types](../../debugger/debug-interface-access/lexical-hierarchy-of-symbol-types.md).

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [Lexical Hierarchy of Symbol Types](../../debugger/debug-interface-access/lexical-hierarchy-of-symbol-types.md)