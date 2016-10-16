---
title: "FuncDebugEnd"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FuncDebugEnd symbol"
  - "debugging [DIA SDK], end point"
ms.assetid: 68f84fff-7cd3-4636-b929-7063a45009f8
caps.latest.revision: 19
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# FuncDebugEnd
If a function has a defined point at which debugging is to end, the debug starting point is identified by a symbol with a `SymTagFuncDebugEnd` tag.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_addressOffset](../debugger/idiasymbol--get_addressoffset.md)|`DWORD`|Offset part of location; for details, see the [LocationType Enumeration](../debugger/locationtype.md).|  
|[IDiaSymbol::get_addressSection](../debugger/idiasymbol--get_addresssection.md)|`DWORD`|Section part of location; for details, see the [LocationType Enumeration](../debugger/locationtype.md).|  
|[IDiaSymbol::get_customCallingConvention](../debugger/idiasymbol--get_customcallingconvention.md)|`BOOL`|`TRUE` if the function uses a custom calling convention (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_farReturn](../debugger/idiasymbol--get_farreturn.md)|`BOOL`|`TRUE` if function performs a far return (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_interruptReturn](../debugger/idiasymbol--get_interruptreturn.md)|`BOOL`|`TRUE` if function contains a return from interrupt (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_isStatic](../debugger/idiasymbol--get_isstatic.md)|`BOOL`|`TRUE` if the function is static (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_lexicalParent](../debugger/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol for the enclosing function.|  
|[IDiaSymbol::get_lexicalParentId](../debugger/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_locationType](../debugger/idiasymbol--get_locationtype.md)|`DWORD`|End points have static location; for details, see [Symbol Locations](../debugger/symbol-locations.md).|  
|[IDiaSymbol::get_noInline](../debugger/idiasymbol--get_noinline.md)|`BOOL`|`TRUE` if the function was specified with the [noinline](../Topic/noinline.md) attribute (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_noReturn](../debugger/idiasymbol--get_noreturn.md)|`BOOL`|`TRUE` if the function was specified with the [noreturn](../Topic/noreturn.md) attribute (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_notReached](../debugger/idiasymbol--get_notreached.md)|`BOOL`|`TRUE` if the function is never called (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_offset](../debugger/idiasymbol--get_offset.md)|`LONG`|Offset of symbol in memory; for details, see the [LocationType Enumeration](../debugger/locationtype.md), `LocIsRegRel`.|  
|[IDiaSymbol::get_optimizedCodeDebugInfo](../debugger/idiasymbol--get_optimizedcodedebuginfo.md)|`BOOL`|`TRUE` if the function has debug information for optimized code (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_symIndexId](../debugger/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_relativeVirtualAddress](../debugger/idiasymbol--get_relativevirtualaddress.md)|`DWORD`|Relative position of the end of this function within its module.|  
|[IDiaSymbol::get_symTag](../debugger/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagFuncDebugEnd` (one of the [SymTagEnum Enumeration](../debugger/symtagenum.md) values).|  
|[IDiaSymbol::get_virtualAddress](../debugger/idiasymbol--get_virtualaddress.md)|`ULONGLONG`|Position of this function within the executable image.|  
  
## See Also  
 [Lexical Hierarchy of Symbol Types](../debugger/lexical-hierarchy-of-symbol-types.md)   
 [LocationType Enumeration](../debugger/locationtype.md)   
 [Symbol Locations](../debugger/symbol-locations.md)