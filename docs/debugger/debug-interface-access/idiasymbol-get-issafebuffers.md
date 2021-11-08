---
description: "Retrieves a flag that specifies whether the preprocesser directive for a safe buffer is used."
title: "IDiaSymbol::get_isSafeBuffers | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_isSafeBuffers method"
ms.assetid: f29e373d-e7bb-4181-ab9f-bf708d401d83
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_isSafeBuffers
Retrieves a flag that specifies whether the preprocesser directive for a safe buffer is used. Use when the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) is set to `SymTagFunction`.

## Syntax

```C++
HRESULT get_isSafeBuffers( 
   BOOL* pRetVal)
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the pointer uses a preprocessor directive for a safe buffer; otherwise, returns `FALSE`.

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
- [strict_gs_check](/cpp/preprocessor/strict-gs-check)
