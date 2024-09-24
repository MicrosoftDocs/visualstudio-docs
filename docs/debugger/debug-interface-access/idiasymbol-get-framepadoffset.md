---
description: Retrieves the offset of the stack pad from the frame pointer register.
title: "IDiaSymbol::get_framePadOffset"
ms.date: "04/27/2021"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_framePadOffset method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_framePadOffset

Retrieves the offset of the stack pad from the frame pointer register.

## Syntax

```C++
HRESULT get_framePadOffset ( 
   DWORD* pPadOffset
);
```

#### Parameters

 `pPadOffset`

[out] Returns the offset of the stack pad.

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
