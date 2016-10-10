---
title: "FuncDebugStart"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1cbc6ca5-87d0-4c30-a39e-0a9dc62ce1a9
caps.latest.revision: 18
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# FuncDebugStart
If a function has a defined point at which debugging is to begin, that point is identified by a symbol with a `SymTagFuncDebugStart` tag.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_addressOffset](../VS_debugger/IDiaSymbol--get_addressOffset.md)|`DWORD`|Offset part of location; for details, see the [LocationType Enumeration](../VS_debugger/LocationType.md).|  
|[IDiaSymbol::get_addressSection](../VS_debugger/IDiaSymbol--get_addressSection.md)|`DWORD`|Section part of location; for details, see the [LocationType Enumeration](../VS_debugger/LocationType.md).|  
|[IDiaSymbol::get_customCallingConvention](../VS_debugger/IDiaSymbol--get_customCallingConvention.md)|`BOOL`|`TRUE` if the function uses a custom calling convention (only in DIA SDK v8.0 or later).|  
|[IDiaSymbol::get_farReturn](../VS_debugger/IDiaSymbol--get_farReturn.md)|`BOOL`|`TRUE` if function performs a far return (only in DIA SDK v8.0 or later).|  
|[IDiaSymbol::get_interruptReturn](../VS_debugger/IDiaSymbol--get_interruptReturn.md)|`BOOL`|`TRUE` if function contains a return from interrupt (only in DIA SDK v8.0 or later).|  
|[IDiaSymbol::get_isStatic](../VS_debugger/IDiaSymbol--get_isStatic.md)|`BOOL`|`TRUE` if function is marked as static (only in DIA SDK v8.0 or later).|  
|[IDiaSymbol::get_lexicalParent](../VS_debugger/IDiaSymbol--get_lexicalParent.md)|`IDiaSymbol*`|Symbol for the enclosing function.|  
|[IDiaSymbol::get_lexicalParentId](../VS_debugger/IDiaSymbol--get_lexicalParentId.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_locationType](../VS_debugger/IDiaSymbol--get_locationType.md)|`DWORD`|Start points have static locations; for details, see [Symbol Locations](../VS_debugger/Symbol-Locations.md).|  
|[IDiaSymbol::get_noInline](../VS_debugger/IDiaSymbol--get_noInline.md)|`BOOL`|`TRUE` if the function was specified with the [noinline](../Topic/noinline.md) attribute (only in DIA SDK v8.0 or later).|  
|[IDiaSymbol::get_noReturn](../VS_debugger/IDiaSymbol--get_noReturn.md)|`BOOL`|`TRUE` if the function was specified with the [noreturn](../Topic/noreturn.md) attribute (only in DIA SDK v8.0 or later).|  
|[IDiaSymbol::get_notReached](../VS_debugger/IDiaSymbol--get_notReached.md)|`BOOL`|`TRUE` if the function is never called (only in DIA SDK v8.0 or later).|  
|[IDiaSymbol::get_offset](../VS_debugger/IDiaSymbol--get_offset.md)|`LONG`|Offset of symbol in memory; for details, see the [LocationType Enumeration](../VS_debugger/LocationType.md), `LocIsRegRel`.|  
|[IDiaSymbol::get_optimizedCodeDebugInfo](../VS_debugger/IDiaSymbol--get_optimizedCodeDebugInfo.md)|`BOOL`|`TRUE` if the code has debug information for optimized code (only in DIA SDK v8.0 or later).|  
|[IDiaSymbol::get_relativeVirtualAddress](../VS_debugger/IDiaSymbol--get_relativeVirtualAddress.md)|`DWORD`|Relative position of the function within its block.|  
|[IDiaSymbol::get_symIndexId](../VS_debugger/IDiaSymbol--get_symIndexId.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md)|`DWORD`|Returns `SymTagFuncDebugStart` (one of the [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) values).|  
|[IDiaSymbol::get_virtualAddress](../VS_debugger/IDiaSymbol--get_virtualAddress.md)|`ULONGLONG`|Position of the function within the executable.|  
  
## See Also  
 [Lexical Hierarchy of Symbol Types](../VS_debugger/Lexical-Hierarchy-of-Symbol-Types.md)   
 [LocationType Enumeration](../VS_debugger/LocationType.md)   
 [Symbol Locations](../VS_debugger/Symbol-Locations.md)