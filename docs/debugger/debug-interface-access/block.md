---
title: "Block | Microsoft Docs"
description: Find information about the Block symbol type (SymTagBlock), which identify nested scopes within functions in the Visual Studio debug interface access SDK.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "SymTagBlock symbol"
  - "nested scopes"
  - "Block symbol"
ms.assetid: 95b7b0c1-ecc9-405f-8456-5f9cfb866498
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Block
Each code block is identified by a `SymTagBlock` symbol. Block symbols are used to identify nested scopes within functions.

## Properties
 The following table shows the properties that are valid for this symbol type.

|Property|Data type|Description|
|--------------|---------------|-----------------|
|[IDiaSymbol::get_addressOffset](../../debugger/debug-interface-access/idiasymbol-get-addressoffset.md)|`DWORD`|Offset part of location; for details, see the [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md).|
|[IDiaSymbol::get_addressSection](../../debugger/debug-interface-access/idiasymbol-get-addresssection.md)|`DWORD`|Section part of location; for details, see the [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md).|
|[IDiaSymbol::get_length](../../debugger/debug-interface-access/idiasymbol-get-length.md)|`ULONGLONG`|Number of bytes of code in the block.|
|[IDiaSymbol::get_lexicalParent](../../debugger/debug-interface-access/idiasymbol-get-lexicalparent.md)|`IDiaSymbol*`|Symbol of the enclosing block or function.|
|[IDiaSymbol::get_lexicalParentId](../../debugger/debug-interface-access/idiasymbol-get-lexicalparentid.md)|`DWORD`|Returns the ID of the lexical parent symbol.|
|[IDiaSymbol::get_locationType](../../debugger/debug-interface-access/idiasymbol-get-locationtype.md)|`DWORD`|Blocks have static locations; for details, see [Symbol Locations](../../debugger/debug-interface-access/symbol-locations.md).|
|[IDiaSymbol::get_name](../../debugger/debug-interface-access/idiasymbol-get-name.md)|`BSTR`|Returns the name of the block (which is usually an empty string).|
|[IDiaSymbol::get_relativeVirtualAddress](../../debugger/debug-interface-access/idiasymbol-get-relativevirtualaddress.md)|`DWORD`|Returns the virtual address of this block relative to its lexical parent.|
|[IDiaSymbol::get_symIndexId](../../debugger/debug-interface-access/idiasymbol-get-symindexid.md)|`DWORD`|Index ID of symbol.|
|[IDiaSymbol::get_symTag](../../debugger/debug-interface-access/idiasymbol-get-symtag.md)|`DWORD`|Returns `SymTagBlock` (one of the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) values).|
|[IDiaSymbol::get_virtualAddress](../../debugger/debug-interface-access/idiasymbol-get-virtualaddress.md)|`ULONGLONG`|Returns the virtual address of this block within the executable.|

## See also
- [Lexical Hierarchy of Symbol Types](../../debugger/debug-interface-access/lexical-hierarchy-of-symbol-types.md)
- [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md)
- [Symbol Locations](../../debugger/debug-interface-access/symbol-locations.md)