---
description: "Retrieves a flag indicating whether the module was compiled with the /hotpatch (Create Hotpatchable Image)) compiler switch."
title: "IDiaSymbol::get_isHotpatchable"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_isHotpatchable method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_isHotpatchable

Retrieves a flag indicating whether the module was compiled with the [/hotpatch (Create Hotpatchable Image)](/cpp/build/reference/hotpatch-create-hotpatchable-image) compiler switch.

## Syntax

```C++
HRESULT get_isHotpatchable(
   BOOL *pFlag
);
```

#### Parameters
 `pFlag`

[out] Returns `TRUE` if the module is hot-patchable; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 This property is available from the `SymTagCompilandDetails` symbol type (see [CompilandDetails](../../debugger/debug-interface-access/compilanddetails.md)).

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v8.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [CompilandDetails](../../debugger/debug-interface-access/compilanddetails.md)
