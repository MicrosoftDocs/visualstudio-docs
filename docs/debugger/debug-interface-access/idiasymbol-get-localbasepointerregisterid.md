---
description: "Retrieves the ID of the register that holds a base pointer to local variables on the stack."
title: "IDiaSymbol::get_localBasePointerRegisterId | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_localBasePointerRegisterId method"
ms.assetid: 9cbcaf00-9ace-45e1-b164-7a9439e08083
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_localBasePointerRegisterId
Retrieves the ID of the register that holds a base pointer to local variables on the stack. Use when the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) is set to `SymTagFunction`.

## Syntax

```C++
HRESULT get_localBasePointerRegisterId ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the ID of the register that holds a base pointer to local variables on the stack.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks

## Requirements
 Header: Dia2.h

 Library: diaguids.lib

 DLL: msdia100.dll

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
