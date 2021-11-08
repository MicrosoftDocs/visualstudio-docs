---
description: "If a function has a defined point at which debugging is to begin, that point is identified by a symbol with a SymTagFuncDebugStart tag."
title: "FuncDebugStart | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "FuncDebugStart symbol"
  - "debugging [DIA SDK], start point"
ms.assetid: 1cbc6ca5-87d0-4c30-a39e-0a9dc62ce1a9
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# FuncDebugStart
If a function has a defined point at which debugging is to begin, that point is identified by a symbol with a `SymTagFuncDebugStart` tag.

## Properties
 The following table shows the properties that are valid for this symbol type.

|Property|Data type|Description|
|--------------|---------------|-----------------|
|[IDiaSymbol::get_addressOffset](../../debugger/debug-interface-access/idiasymbol-get-addressoffset.md)|`DWORD`|Offset part of location; for details, see the [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md).|
|[IDiaSymbol::get_addressSection](../../debugger/debug-interface-access/idiasymbol-get-addresssection.md)|`DWORD`|Section part of location; for details, see the [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md).|
|[IDiaSymbol::get_customCallingConvention](../../debugger/debug-interface-access/idiasymbol-get-customcallingconvention.md)|`BOOL`|`TRUE` if the function uses a custom calling convention (only in DIA SDK v8.0 or later).|
|[IDiaSymbol::get_farReturn](../../debugger/debug-interface-access/idiasymbol-get-farreturn.md)|`BOOL`|`TRUE` if function performs a far return (only in DIA SDK v8.0 or later).|
|[IDiaSymbol::get_interruptReturn](../../debugger/debug-interface-access/idiasymbol-get-interruptreturn.md)|`BOOL`|`TRUE` if function contains a return from interrupt (only in DIA SDK v8.0 or later).|
|[IDiaSymbol::get_isStatic](../../debugger/debug-interface-access/idiasymbol-get-isstatic.md)|`BOOL`|`TRUE` if function is marked as static (only in DIA SDK v8.0 or later).|
|[IDiaSymbol::get_lexicalParent](../../debugger/debug-interface-access/idiasymbol-get-lexicalparent.md)|`IDiaSymbol*`|Symbol for the enclosing function.|
|[IDiaSymbol::get_lexicalParentId](../../debugger/debug-interface-access/idiasymbol-get-lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|
|[IDiaSymbol::get_locationType](../../debugger/debug-interface-access/idiasymbol-get-locationtype.md)|`DWORD`|Start points have static locations; for details, see [Symbol Locations](../../debugger/debug-interface-access/symbol-locations.md).|
|[IDiaSymbol::get_noInline](../../debugger/debug-interface-access/idiasymbol-get-noinline.md)|`BOOL`|`TRUE` if the function was specified with the [noinline](/cpp/cpp/noinline) attribute (only in DIA SDK v8.0 or later).|
|[IDiaSymbol::get_noReturn](../../debugger/debug-interface-access/idiasymbol-get-noreturn.md)|`BOOL`|`TRUE` if the function was specified with the [noreturn](/cpp/cpp/noreturn) attribute (only in DIA SDK v8.0 or later).|
|[IDiaSymbol::get_notReached](../../debugger/debug-interface-access/idiasymbol-get-notreached.md)|`BOOL`|`TRUE` if the function is never called (only in DIA SDK v8.0 or later).|
|[IDiaSymbol::get_offset](../../debugger/debug-interface-access/idiasymbol-get-offset.md)|`LONG`|Offset of symbol in memory; for details, see the [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md), `LocIsRegRel`.|
|[IDiaSymbol::get_optimizedCodeDebugInfo](../../debugger/debug-interface-access/idiasymbol-get-optimizedcodedebuginfo.md)|`BOOL`|`TRUE` if the code has debug information for optimized code (only in DIA SDK v8.0 or later).|
|[IDiaSymbol::get_relativeVirtualAddress](../../debugger/debug-interface-access/idiasymbol-get-relativevirtualaddress.md)|`DWORD`|Relative position of the function within its block.|
|[IDiaSymbol::get_symIndexId](../../debugger/debug-interface-access/idiasymbol-get-symindexid.md)|`DWORD`|Index ID of symbol.|
|[IDiaSymbol::get_symTag](../../debugger/debug-interface-access/idiasymbol-get-symtag.md)|`DWORD`|Returns `SymTagFuncDebugStart` (one of the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) values).|
|[IDiaSymbol::get_virtualAddress](../../debugger/debug-interface-access/idiasymbol-get-virtualaddress.md)|`ULONGLONG`|Position of the function within the executable.|

## See also
- [Lexical Hierarchy of Symbol Types](../../debugger/debug-interface-access/lexical-hierarchy-of-symbol-types.md)
- [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md)
- [Symbol Locations](../../debugger/debug-interface-access/symbol-locations.md)
