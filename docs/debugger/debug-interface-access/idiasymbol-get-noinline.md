---
description: "Retrieves a flag that specifies whether the function has been marked as being not inline (using the noinline) attribute)."
title: "IDiaSymbol::get_noInline | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_noInline method"
ms.assetid: 5c610b78-f1a3-494a-acf8-c42b97935be1
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_noInline
Retrieves a flag that specifies whether the function has been marked as being not inline (using the [noinline](/cpp/cpp/noinline) attribute).

## Syntax

```C++
HRESULT get_noInline(
   BOOL *pFlag
);
```

#### Parameters
 `pFlag`

[out] Returns `TRUE` if the function has the `noinline` attribute; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v8.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [noinline](/cpp/cpp/noinline)
