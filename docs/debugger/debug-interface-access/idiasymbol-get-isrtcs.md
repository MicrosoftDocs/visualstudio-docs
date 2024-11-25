---
description: "Retrieves a value that tells whether the function was compiled with stack frame run-time error checking. This is the /RTCs flag."
title: "IDiaSymbol::get_isRTCs"
ms.date: "04/27/2021"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_isRTCs method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_isRTCs

Returns a value that tells whether the function was compiled with stack frame run-time error checking. This is the /RTCs flag.

## Syntax

```C++
HRESULT get_isRTCs ( 
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] A pointer to a BOOL that specifies whether the function was compiled with stack frame run-time error checking.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks

This method is supported starting in Visual Studio 2019 version 16.10 Preview 2.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v7.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
