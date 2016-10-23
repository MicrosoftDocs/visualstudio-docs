---
title: "Label (Debug Interface Access SDK)"
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
ms.assetid: 8cef7620-5bc8-4500-8bd0-e9e638bccb24
caps.latest.revision: 17
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
# Label (Debug Interface Access SDK)
A location in program code is identified by a `SymTagLabel` symbol.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_addressOffset](../VS_debugger/IDiaSymbol--get_addressOffset.md)|`DWORD`|Offset part of location; for details, see the [LocationType Enumeration](../VS_debugger/LocationType.md).|  
|[IDiaSymbol::get_addressSection](../VS_debugger/IDiaSymbol--get_addressSection.md)|`DWORD`|Section part of location; for details, see the [LocationType Enumeration](../VS_debugger/LocationType.md).|  
|[IDiaSymbol::get_customCallingConvention](../VS_debugger/IDiaSymbol--get_customCallingConvention.md)|`BOOL`|`TRUE` if the label uses a custom calling convention.|  
|[IDiaSymbol::get_farReturn](../VS_debugger/IDiaSymbol--get_farReturn.md)|`BOOL`|`TRUE` if label performs a far return.|  
|[IDiaSymbol::get_interruptReturn](../VS_debugger/IDiaSymbol--get_interruptReturn.md)|`BOOL`|`TRUE` if label contains a return from interrupt.|  
|[IDiaSymbol::get_lexicalParent](../VS_debugger/IDiaSymbol--get_lexicalParent.md)|`IDiaSymbol*`|Symbol for the enclosing compiland, block, or function.|  
|[IDiaSymbol::get_lexicalParentId](../VS_debugger/IDiaSymbol--get_lexicalParentId.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_locationType](../VS_debugger/IDiaSymbol--get_locationType.md)|`DWORD`|Labels have static locations; for details, see the [Symbol Locations](../VS_debugger/Symbol-Locations.md) enumeration.|  
|[IDiaSymbol::get_name](../VS_debugger/IDiaSymbol--get_name.md)|`BSTR`|The label's name.|  
|[IDiaSymbol::get_noInline](../VS_debugger/IDiaSymbol--get_noInline.md)|`BOOL`|`TRUE` if the label was specified with the [noinline](../Topic/noinline.md) attribute.|  
|[IDiaSymbol::get_noReturn](../VS_debugger/IDiaSymbol--get_noReturn.md)|`BOOL`|`TRUE` if the label was specified with the [noreturn](../Topic/noreturn.md) attribute.|  
|[IDiaSymbol::get_notReached](../VS_debugger/IDiaSymbol--get_notReached.md)|`BOOL`|`TRUE` if the label is never called.|  
|[IDiaSymbol::get_offset](../VS_debugger/IDiaSymbol--get_offset.md)|`LONG`|Offset of symbol in memory; for details, see the [LocationType Enumeration](../VS_debugger/LocationType.md), `LocIsRegRel`.|  
|[IDiaSymbol::get_optimizedCodeDebugInfo](../VS_debugger/IDiaSymbol--get_optimizedCodeDebugInfo.md)|`BOOL`|`TRUE` if the code has debug information for optimized code.|  
|[IDiaSymbol::get_relativeVirtualAddress](../VS_debugger/IDiaSymbol--get_relativeVirtualAddress.md)|`DWORD`|Relative position of this label within its module.|  
|[IDiaSymbol::get_symIndexId](../VS_debugger/IDiaSymbol--get_symIndexId.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md)|`DWORD`|Returns `SymTagFuncDebugLabel` (one of the [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) values).|  
|[IDiaSymbol::get_virtualAddress](../VS_debugger/IDiaSymbol--get_virtualAddress.md)|`ULONGLONG`|Position of this label within the executable image.|  
  
## See Also  
 [Lexical Hierarchy of Symbol Types](../VS_debugger/Lexical-Hierarchy-of-Symbol-Types.md)   
 [LocationType Enumeration](../VS_debugger/LocationType.md)   
 [Symbol Locations](../VS_debugger/Symbol-Locations.md)