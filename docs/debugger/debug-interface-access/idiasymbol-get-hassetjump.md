---
description: Retrieves a flag that specifies whether the function contains a use of the setjmp) command (paired with the longjmp(/cpp/c-runtime-library/reference/longjmp) command, these form the C-style method of exception handling).
title: "IDiaSymbol::get_hasSetJump"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_hasSetJump method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_hasSetJump

Retrieves a flag that specifies whether the function contains a use of the [setjmp](/cpp/c-runtime-library/reference/setjmp) command (paired with the [longjmp](/cpp/c-runtime-library/reference/longjmp) command, these form the C-style method of exception handling).

## Syntax

```C++
HRESULT get_hasSetJump(
   BOOL *pFlag
);
```

#### Parameters
 `pFlag`

[out] Returns `TRUE` if the function contains a `setjmp` command; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v8.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [IDiaSymbol::get_hasLongJump](../../debugger/debug-interface-access/idiasymbol-get-haslongjump.md)
- [longjmp](/cpp/c-runtime-library/reference/longjmp)
- [setjmp](/cpp/c-runtime-library/reference/setjmp)
