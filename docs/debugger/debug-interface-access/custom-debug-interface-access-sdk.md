---
title: Custom (Debug Interface Access SDK)
description: Find reference information about custom symbol types (identified with the SymTagCustom tag) in the Visual Studio Debug Interface Access SDK.
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "Custom symbol"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Custom (Debug Interface Access SDK)

Some compilers introduce symbols that are not identified by any of the standard lexical symbol types. These symbols are identified by a `SymTagCustom` tag.

## Properties

The following table shows the properties that are valid for this symbol type.

|Property|Data type|Description|
|--------------|---------------|-----------------|
|[IDiaSymbol::get_dataBytes](../../debugger/debug-interface-access/idiasymbol-get-databytes.md)|`BYTE`|Array of data associated with the symbol.|
|[IDiaSymbol::get_symIndexId](../../debugger/debug-interface-access/idiasymbol-get-symindexid.md)|`DWORD`|Index ID of symbol.|
|[IDiaSymbol::get_symTag](../../debugger/debug-interface-access/idiasymbol-get-symtag.md)|`DWORD`|Returns `SymTagCustom` (one of the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) values).|

## See also

- [Lexical Hierarchy of Symbol Types](../../debugger/debug-interface-access/lexical-hierarchy-of-symbol-types.md)
