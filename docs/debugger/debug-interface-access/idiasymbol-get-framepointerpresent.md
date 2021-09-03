---
description: "Retrieves a flag that specifies whether the frame pointer is present."
title: "IDiaSymbol::get_framePointerPresent | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_framePointerPresent method"
ms.assetid: d036090a-1651-454d-9130-b798f58ba053
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_framePointerPresent
Retrieves a flag that specifies whether the frame pointer is present. Use when the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) is set to `SymTagFunction`.

## Syntax

```C++
HRESULT get_framePointerPresent( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] ] Returns `TRUE` if the frame pointer is present; otherwise, returns `FALSE`.

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
