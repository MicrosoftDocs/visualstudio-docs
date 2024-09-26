---
description: Retrieves the extra pad size added to each function.
title: "IDiaSymbol::get_framePadSize"
ms.date: "04/27/2021"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_framePadSize method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_framePadSize

Retrieves the extra pad size added to each function.

## Syntax

```C++
HRESULT get_framePadSize ( 
   DWORD* pPadSize
);
```

#### Parameters

 `pPadSize`

[out] Returns the extra pad size added to each function.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks

The extra pad size is typically used by Edit and Continue.

This method is supported starting in Visual Studio 2019 version 16.10 Preview 2.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v7.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
