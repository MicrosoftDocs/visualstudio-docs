---
title: "PublicSymbol"
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
  - "data symbols [C++]"
  - "PublicSymbol symbol"
  - "global functions [C++], as public symbols"
ms.assetid: f8d33007-302d-4549-9dad-47fb33ea60b7
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
# PublicSymbol
When the .exe file is created, each public symbol (at a minimum, each global function and data symbol) is given a `SymTagPublicSymbol` tag.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_addressOffset](../debugger/idiasymbol--get_addressoffset.md)|`DWORD`|Offset part of location; for details, see the [LocationType Enumeration](../debugger/locationtype.md).|  
|[IDiaSymbol::get_addressSection](../debugger/idiasymbol--get_addresssection.md)|`DWORD`|Section part of location; for details, see the [LocationType Enumeration](../debugger/locationtype.md).|  
|[IDiaSymbol::get_code](../debugger/idiasymbol--get_code.md)|`BOOL`|`TRUE` if the symbol's location is in code.|  
|[IDiaSymbol::get_function](../debugger/idiasymbol--get_function.md)|`BOOL`|`TRUE` if the symbol is a function.|  
|[IDiaSymbol::get_length](../debugger/idiasymbol--get_length.md)|`ULONGLONG`|Length of this symbol in bytes.|  
|[IDiaSymbol::get_lexicalParent](../debugger/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol for the global scope.|  
|[IDiaSymbol::get_lexicalParentId](../debugger/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_locationType](../debugger/idiasymbol--get_locationtype.md)|`DWORD`|Public symbols have static locations; for details, see [Symbol Locations](../debugger/symbol-locations.md).|  
|[IDiaSymbol::get_managed](../debugger/idiasymbol--get_managed.md)|`BOOL`|`TRUE` if the symbol's location is in managed code.|  
|[IDiaSymbol::get_msil](../debugger/idiasymbol--get_msil.md)|`BOOL`|`TRUE` if the symbol's location is in Microsoft Intermediate Language (MSIL) code.|  
|[IDiaSymbol::get_name](../debugger/idiasymbol--get_name.md)|`BSTR`|The fully decorated name of the symbol.|  
|[IDiaSymbol::get_symIndexId](../debugger/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_relativeVirtualAddress](../debugger/idiasymbol--get_relativevirtualaddress.md)|`DWORD`|Relative position of the symbol within its block.|  
|[IDiaSymbol::get_symTag](../debugger/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagPublicSymbol` (one of the [SymTagEnum Enumeration](../debugger/symtagenum.md) values).|  
|[IDiaSymbol::get_undecoratedName](../debugger/idiasymbol--get_undecoratedname.md)|`BSTR`|The undecorated symbol name.|  
|[IDiaSymbol::get_undecoratedNameEx](../debugger/idiasymbol--get_undecoratednameex.md)|`BSTR`|Part or all of the undecorated symbol name.|  
  
## See Also  
 [Lexical Hierarchy of Symbol Types](../debugger/lexical-hierarchy-of-symbol-types.md)   
 [LocationType Enumeration](../debugger/locationtype.md)   
 [Symbol Locations](../debugger/symbol-locations.md)