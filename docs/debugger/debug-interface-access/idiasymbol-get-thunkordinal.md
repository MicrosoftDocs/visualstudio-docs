---
description: "Retrieves the thunk type of a function."
title: "IDiaSymbol::get_thunkOrdinal | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_thunkOrdinal method"
ms.assetid: 4b28d78a-1974-4d8a-8bb7-781bf630f2f4
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_thunkOrdinal
Retrieves the thunk type of a function.

## Syntax

```C++
HRESULT get_thunkOrdinal ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns a value from the [THUNK_ORDINAL Enumeration](../../debugger/debug-interface-access/thunk-ordinal.md) enumeration that specifies the thunk type of a function.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 This property is valid only if the symbol as a [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) value of `SymTagThunk`.

 A "thunk" is a piece of code that converts between a 32-bit memory address space (also known as flat address space) and a 16-bit address space (known as a segmented address space).

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [THUNK_ORDINAL Enumeration](../../debugger/debug-interface-access/thunk-ordinal.md)
- [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md)
