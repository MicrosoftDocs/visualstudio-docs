---
title: "CustomType | Microsoft Docs"
description: Find reference information about the CustomType symbol type (SymTagCustomType) in the Visual Studio debug interface access SDK.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "CustomType symbol"
ms.assetid: 1b66bc0a-7979-416f-bf7f-e5df91584c91
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# CustomType
Vendor-defined types (compiler-specific types) are identified by a `SymTagCustomType` symbol.

## Properties
 The following table shows additional valid properties for this symbol type.

|Property|Data type|Description|
|--------------|---------------|-----------------|
|[IDiaSymbol::get_oemId](../../debugger/debug-interface-access/idiasymbol-get-oemid.md)|`DWORD`|Identifier of OEM.|
|[IDiaSymbol::get_oemSymbolId](../../debugger/debug-interface-access/idiasymbol-get-oemsymbolid.md)|`DWORD`|OEM's internal ID.|
|[IDiaSymbol::get_symIndexId](../../debugger/debug-interface-access/idiasymbol-get-symindexid.md)|`DWORD`|Index ID of symbol.|
|[IDiaSymbol::get_symTag](../../debugger/debug-interface-access/idiasymbol-get-symtag.md)|`DWORD`|Returns `SymTagCustomType` (one of the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) values).|
|[IDiaSymbol::get_type](../../debugger/debug-interface-access/idiasymbol-get-type.md)|`IDiaSymbol*`|The first type referenced by the custom type symbol.|
|[IDiaSymbol::get_typeId](../../debugger/debug-interface-access/idiasymbol-get-typeid.md)|`DWORD`|ID of the type symbol.|
|[IDiaSymbol::get_types](../../debugger/debug-interface-access/idiasymbol-get-types.md)|`IDiaSymbol**`|Array of all types referenced by the custom type symbol.|

## See also
- [Class Hierarchy of Symbol Types](../../debugger/debug-interface-access/class-hierarchy-of-symbol-types.md)