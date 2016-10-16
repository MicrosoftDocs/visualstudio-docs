---
title: "Label (Debug Interface Access SDK)"
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
  - "locations, in program code"
  - "Label symbol"
ms.assetid: 8cef7620-5bc8-4500-8bd0-e9e638bccb24
caps.latest.revision: 17
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
# Label (Debug Interface Access SDK)
A location in program code is identified by a `SymTagLabel` symbol.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_addressOffset](../debugger/idiasymbol--get_addressoffset.md)|`DWORD`|Offset part of location; for details, see the [LocationType Enumeration](../debugger/locationtype.md).|  
|[IDiaSymbol::get_addressSection](../debugger/idiasymbol--get_addresssection.md)|`DWORD`|Section part of location; for details, see the [LocationType Enumeration](../debugger/locationtype.md).|  
|[IDiaSymbol::get_customCallingConvention](../debugger/idiasymbol--get_customcallingconvention.md)|`BOOL`|`TRUE` if the label uses a custom calling convention.|  
|[IDiaSymbol::get_farReturn](../debugger/idiasymbol--get_farreturn.md)|`BOOL`|`TRUE` if label performs a far return.|  
|[IDiaSymbol::get_interruptReturn](../debugger/idiasymbol--get_interruptreturn.md)|`BOOL`|`TRUE` if label contains a return from interrupt.|  
|[IDiaSymbol::get_lexicalParent](../debugger/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol for the enclosing compiland, block, or function.|  
|[IDiaSymbol::get_lexicalParentId](../debugger/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_locationType](../debugger/idiasymbol--get_locationtype.md)|`DWORD`|Labels have static locations; for details, see the [Symbol Locations](../debugger/symbol-locations.md) enumeration.|  
|[IDiaSymbol::get_name](../debugger/idiasymbol--get_name.md)|`BSTR`|The label's name.|  
|[IDiaSymbol::get_noInline](../debugger/idiasymbol--get_noinline.md)|`BOOL`|`TRUE` if the label was specified with the [noinline](../Topic/noinline.md) attribute.|  
|[IDiaSymbol::get_noReturn](../debugger/idiasymbol--get_noreturn.md)|`BOOL`|`TRUE` if the label was specified with the [noreturn](../Topic/noreturn.md) attribute.|  
|[IDiaSymbol::get_notReached](../debugger/idiasymbol--get_notreached.md)|`BOOL`|`TRUE` if the label is never called.|  
|[IDiaSymbol::get_offset](../debugger/idiasymbol--get_offset.md)|`LONG`|Offset of symbol in memory; for details, see the [LocationType Enumeration](../debugger/locationtype.md), `LocIsRegRel`.|  
|[IDiaSymbol::get_optimizedCodeDebugInfo](../debugger/idiasymbol--get_optimizedcodedebuginfo.md)|`BOOL`|`TRUE` if the code has debug information for optimized code.|  
|[IDiaSymbol::get_relativeVirtualAddress](../debugger/idiasymbol--get_relativevirtualaddress.md)|`DWORD`|Relative position of this label within its module.|  
|[IDiaSymbol::get_symIndexId](../debugger/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../debugger/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagFuncDebugLabel` (one of the [SymTagEnum Enumeration](../debugger/symtagenum.md) values).|  
|[IDiaSymbol::get_virtualAddress](../debugger/idiasymbol--get_virtualaddress.md)|`ULONGLONG`|Position of this label within the executable image.|  
  
## See Also  
 [Lexical Hierarchy of Symbol Types](../debugger/lexical-hierarchy-of-symbol-types.md)   
 [LocationType Enumeration](../debugger/locationtype.md)   
 [Symbol Locations](../debugger/symbol-locations.md)