---
description: Retrieves a flag that specifies whether the function contains a return from interrupt instruction (for example, the X86 assembly code iret`).
title: "IDiaSymbol::get_interruptReturn"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_interruptReturn method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_interruptReturn

Retrieves a flag that specifies whether the function contains a return from interrupt instruction (for example, the X86 assembly code `iret`).

## Syntax

```C++
HRESULT get_interruptReturn(
   BOOL *pFlag
);
```

#### Parameters
 `pFlag`

[out] Returns `TRUE` if the function has a return from interrupt instruction; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v8.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
