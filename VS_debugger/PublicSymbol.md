---
title: "PublicSymbol"
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
ms.assetid: f8d33007-302d-4549-9dad-47fb33ea60b7
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
# PublicSymbol
When the .exe file is created, each public symbol (at a minimum, each global function and data symbol) is given a `SymTagPublicSymbol` tag.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_addressOffset](../VS_debugger/IDiaSymbol--get_addressOffset.md)|`DWORD`|Offset part of location; for details, see the [LocationType Enumeration](../VS_debugger/LocationType.md).|  
|[IDiaSymbol::get_addressSection](../VS_debugger/IDiaSymbol--get_addressSection.md)|`DWORD`|Section part of location; for details, see the [LocationType Enumeration](../VS_debugger/LocationType.md).|  
|[IDiaSymbol::get_code](../VS_debugger/IDiaSymbol--get_code.md)|`BOOL`|`TRUE` if the symbol's location is in code.|  
|[IDiaSymbol::get_function](../VS_debugger/IDiaSymbol--get_function.md)|`BOOL`|`TRUE` if the symbol is a function.|  
|[IDiaSymbol::get_length](../VS_debugger/IDiaSymbol--get_length.md)|`ULONGLONG`|Length of this symbol in bytes.|  
|[IDiaSymbol::get_lexicalParent](../VS_debugger/IDiaSymbol--get_lexicalParent.md)|`IDiaSymbol*`|Symbol for the global scope.|  
|[IDiaSymbol::get_lexicalParentId](../VS_debugger/IDiaSymbol--get_lexicalParentId.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_locationType](../VS_debugger/IDiaSymbol--get_locationType.md)|`DWORD`|Public symbols have static locations; for details, see [Symbol Locations](../VS_debugger/Symbol-Locations.md).|  
|[IDiaSymbol::get_managed](../VS_debugger/IDiaSymbol--get_managed.md)|`BOOL`|`TRUE` if the symbol's location is in managed code.|  
|[IDiaSymbol::get_msil](../VS_debugger/IDiaSymbol--get_msil.md)|`BOOL`|`TRUE` if the symbol's location is in Microsoft Intermediate Language (MSIL) code.|  
|[IDiaSymbol::get_name](../VS_debugger/IDiaSymbol--get_name.md)|`BSTR`|The fully decorated name of the symbol.|  
|[IDiaSymbol::get_symIndexId](../VS_debugger/IDiaSymbol--get_symIndexId.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_relativeVirtualAddress](../VS_debugger/IDiaSymbol--get_relativeVirtualAddress.md)|`DWORD`|Relative position of the symbol within its block.|  
|[IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md)|`DWORD`|Returns `SymTagPublicSymbol` (one of the [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) values).|  
|[IDiaSymbol::get_undecoratedName](../VS_debugger/IDiaSymbol--get_undecoratedName.md)|`BSTR`|The undecorated symbol name.|  
|[IDiaSymbol::get_undecoratedNameEx](../VS_debugger/IDiaSymbol--get_undecoratedNameEx.md)|`BSTR`|Part or all of the undecorated symbol name.|  
  
## See Also  
 [Lexical Hierarchy of Symbol Types](../VS_debugger/Lexical-Hierarchy-of-Symbol-Types.md)   
 [LocationType Enumeration](../VS_debugger/LocationType.md)   
 [Symbol Locations](../VS_debugger/Symbol-Locations.md)