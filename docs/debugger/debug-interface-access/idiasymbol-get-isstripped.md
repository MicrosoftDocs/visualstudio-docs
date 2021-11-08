---
description: "Retrieves flag indicating whether private symbols were stripped from the symbol file."
title: "IDiaSymbol::get_isStripped | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_isStripped method"
ms.assetid: cc2c4a0b-ab9f-4b79-a8ff-a3badb0405d6
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_isStripped
Retrieves flag indicating whether private symbols were stripped from the symbol file.

## Syntax

```C++
HRESULT get_isStripped(
   BOOL *pFlag
);
```

#### Parameters
 `pFlag`

[out] Returns `TRUE` if private symbols were removed from the symbol file; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 This property is available from the `SymTagExe` symbol type (see [Exe](../../debugger/debug-interface-access/exe.md)).

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v8.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [Exe](../../debugger/debug-interface-access/exe.md)
