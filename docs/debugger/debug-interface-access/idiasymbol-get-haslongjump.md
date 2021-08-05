---
description: "Retrieves a flag that specifies whether the function contains a use of the longjmp) command (paired with a setjmp(/cpp/c-runtime-library/reference/setjmp) command, these form the C-style method of exception handling)."
title: "IDiaSymbol::get_hasLongJump | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_hasLongJump method"
ms.assetid: 14484cb1-43b0-47a1-a9a8-081b55566886
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_hasLongJump
Retrieves a flag that specifies whether the function contains a use of the [longjmp](/cpp/c-runtime-library/reference/longjmp) command (paired with a [setjmp](/cpp/c-runtime-library/reference/setjmp) command, these form the C-style method of exception handling).

## Syntax

```C++
HRESULT get_hasLongJump
   BOOL *pFlag
);
```

#### Parameters
 `pFlag`

[out] Returns `TRUE` if the function contains a `longjmp` command; otherwise, returns `FALSE`.

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
- [IDiaSymbol::get_hasSetJump](../../debugger/debug-interface-access/idiasymbol-get-hassetjump.md)
- [longjmp](/cpp/c-runtime-library/reference/longjmp)
- [setjmp](/cpp/c-runtime-library/reference/setjmp)
