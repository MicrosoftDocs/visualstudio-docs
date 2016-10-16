---
title: "Block"
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
  - "SymTagBlock symbol"
  - "nested scopes"
  - "Block symbol"
ms.assetid: 95b7b0c1-ecc9-405f-8456-5f9cfb866498
caps.latest.revision: 18
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
# Block
Each code block is identified by a `SymTagBlock` symbol. Block symbols are used to identify nested scopes within functions.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_addressOffset](../debugger/idiasymbol--get_addressoffset.md)|`DWORD`|Offset part of location; for details, see the [LocationType Enumeration](../debugger/locationtype.md).|  
|[IDiaSymbol::get_addressSection](../debugger/idiasymbol--get_addresssection.md)|`DWORD`|Section part of location; for details, see the [LocationType Enumeration](../debugger/locationtype.md).|  
|[IDiaSymbol::get_length](../debugger/idiasymbol--get_length.md)|`ULONGLONG`|Number of bytes of code in the block.|  
|[IDiaSymbol::get_lexicalParent](../debugger/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol of the enclosing block or function.|  
|[IDiaSymbol::get_lexicalParentId](../debugger/idiasymbol--get_lexicalparentid.md)|`DWORD`|Returns the ID of the lexical parent symbol.|  
|[IDiaSymbol::get_locationType](../debugger/idiasymbol--get_locationtype.md)|`DWORD`|Blocks have static locations; for details, see [Symbol Locations](../debugger/symbol-locations.md).|  
|[IDiaSymbol::get_name](../debugger/idiasymbol--get_name.md)|`BSTR`|Returns the name of the block (which is usually an empty string).|  
|[IDiaSymbol::get_relativeVirtualAddress](../debugger/idiasymbol--get_relativevirtualaddress.md)|`DWORD`|Returns the virtual address of this block relative to its lexical parent.|  
|[IDiaSymbol::get_symIndexId](../debugger/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../debugger/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagBlock` (one of the [SymTagEnum Enumeration](../debugger/symtagenum.md) values).|  
|[IDiaSymbol::get_virtualAddress](../debugger/idiasymbol--get_virtualaddress.md)|`ULONGLONG`|Returns the virtual address of this block within the executable.|  
  
## See Also  
 [Lexical Hierarchy of Symbol Types](../debugger/lexical-hierarchy-of-symbol-types.md)   
 [LocationType Enumeration](../debugger/locationtype.md)   
 [Symbol Locations](../debugger/symbol-locations.md)