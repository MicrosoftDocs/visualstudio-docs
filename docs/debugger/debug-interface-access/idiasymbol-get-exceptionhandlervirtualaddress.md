---
description: Retrieves the virtual address of the exception handler of this function.
title: "IDiaSymbol::get_exceptionHandlerVirtualAddress"
ms.date: "07/11/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_exceptionHandlerVirtualAddress method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_exceptionHandlerVirtualAddress

Retrieves the virtual address of the exception handler of this function.

## Syntax

```C++
HRESULT get_exceptionHandlerVirtualAddress ( 
   ULONGLONG* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the virtual address of this function's exception handler.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Remarks

For machines that do not use `.pdata` and `.xdata` for exception and unwind information (currently only x86), this method can be used to retrieve the address of the per-function exception inforation.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
