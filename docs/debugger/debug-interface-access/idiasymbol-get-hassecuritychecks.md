---
description: Retrieves a flag that specifies whether the compiland or function has been compiled with buffer-overrun security checks (for example, the /GS (Buffer Security Check)) compiler switch).
title: "IDiaSymbol::get_hasSecurityChecks"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_hasSecurityChecks method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_hasSecurityChecks

Retrieves a flag that specifies whether the compiland or function has been compiled with buffer-overrun security checks (for example, the [/GS (Buffer Security Check)](/cpp/build/reference/gs-buffer-security-check) compiler switch).

## Syntax

```C++
HRESULT get_hasSecurityChecks(
   BOOL *pFlag
);
```

#### Parameters
 `pFlag`

[out] Returns `TRUE` if the function has any security checks; otherwise, returns `FALSE`.

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
- [/GS (Buffer Security Check)](/cpp/build/reference/gs-buffer-security-check)
