---
description: "Retrieves the name of the file from which the symbols were loaded."
title: "IDiaSymbol::get_symbolsFileName | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_symbolsFileName method"
ms.assetid: c1aa39ee-d645-431e-bf5f-0640c0998934
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_symbolsFileName
Retrieves the name of the file from which the symbols were loaded.

## Syntax

```C++
HRESULT get_symbolsFileName ( 
   BSTR* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the name of the file from which the symbols were loaded.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 This property is valid only for symbols with a [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) value of `SymTagExe` that also have global scope.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md)
