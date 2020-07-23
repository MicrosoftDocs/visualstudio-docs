---
title: "IDiaSymbol::get_customCallingConvention | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_customCallingConvention method"
ms.assetid: 0aa97951-f7e1-4fa5-a87f-2920460c122d
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_customCallingConvention
Retrieves a flag that specifies whether the function has a custom calling convention.

## Syntax

```C++
HRESULT get_customCallingConvention(
   BOOL *pFlag
);
```

#### Parameters
 `pFlag`

[out] Returns `TRUE` if the function has a custom calling convention; otherwise, returns `FALSE`, the function has a known calling convention.

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