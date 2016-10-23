---
title: "Block"
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
ms.assetid: 95b7b0c1-ecc9-405f-8456-5f9cfb866498
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
# Block
Each code block is identified by a `SymTagBlock` symbol. Block symbols are used to identify nested scopes within functions.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_addressOffset](../VS_debugger/IDiaSymbol--get_addressOffset.md)|`DWORD`|Offset part of location; for details, see the [LocationType Enumeration](../VS_debugger/LocationType.md).|  
|[IDiaSymbol::get_addressSection](../VS_debugger/IDiaSymbol--get_addressSection.md)|`DWORD`|Section part of location; for details, see the [LocationType Enumeration](../VS_debugger/LocationType.md).|  
|[IDiaSymbol::get_length](../VS_debugger/IDiaSymbol--get_length.md)|`ULONGLONG`|Number of bytes of code in the block.|  
|[IDiaSymbol::get_lexicalParent](../VS_debugger/IDiaSymbol--get_lexicalParent.md)|`IDiaSymbol*`|Symbol of the enclosing block or function.|  
|[IDiaSymbol::get_lexicalParentId](../VS_debugger/IDiaSymbol--get_lexicalParentId.md)|`DWORD`|Returns the ID of the lexical parent symbol.|  
|[IDiaSymbol::get_locationType](../VS_debugger/IDiaSymbol--get_locationType.md)|`DWORD`|Blocks have static locations; for details, see [Symbol Locations](../VS_debugger/Symbol-Locations.md).|  
|[IDiaSymbol::get_name](../VS_debugger/IDiaSymbol--get_name.md)|`BSTR`|Returns the name of the block (which is usually an empty string).|  
|[IDiaSymbol::get_relativeVirtualAddress](../VS_debugger/IDiaSymbol--get_relativeVirtualAddress.md)|`DWORD`|Returns the virtual address of this block relative to its lexical parent.|  
|[IDiaSymbol::get_symIndexId](../VS_debugger/IDiaSymbol--get_symIndexId.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md)|`DWORD`|Returns `SymTagBlock` (one of the [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) values).|  
|[IDiaSymbol::get_virtualAddress](../VS_debugger/IDiaSymbol--get_virtualAddress.md)|`ULONGLONG`|Returns the virtual address of this block within the executable.|  
  
## See Also  
 [Lexical Hierarchy of Symbol Types](../VS_debugger/Lexical-Hierarchy-of-Symbol-Types.md)   
 [LocationType Enumeration](../VS_debugger/LocationType.md)   
 [Symbol Locations](../VS_debugger/Symbol-Locations.md)