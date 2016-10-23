---
title: "PointerType"
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
ms.assetid: 67228681-7345-4537-8af3-93806803ee96
caps.latest.revision: 16
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
# PointerType
Each pointer is identified by a `SymTagPointerType` symbol.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_constType](../VS_debugger/IDiaSymbol--get_constType.md)|`BOOL`|`TRUE` if the pointer is marked as a constant.|  
|[IDiaSymbol::get_length](../VS_debugger/IDiaSymbol--get_length.md)|`ULONGLONG`|Size, in bytes, of the pointer.|  
|[IDiaSymbol::get_lexicalParent](../VS_debugger/IDiaSymbol--get_lexicalParent.md)|`IDiaSymbol*`|Symbol of the enclosing [Compiland](../VS_debugger/Compiland.md).|  
|[IDiaSymbol::get_lexicalParentId](../VS_debugger/IDiaSymbol--get_lexicalParentId.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_reference](../VS_debugger/IDiaSymbol--get_reference.md)|`BOOL`|`TRUE` if pointer is a reference type.|  
|[IDiaSymbol::get_symIndexId](../VS_debugger/IDiaSymbol--get_symIndexId.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md)|`DWORD`|Returns `SymTagPointerType` (one of the [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) values).|  
|[IDiaSymbol::get_type](../VS_debugger/IDiaSymbol--get_type.md)|`IDiaSymbol*`|Target symbol of the pointer.|  
|[IDiaSymbol::get_typeId](../VS_debugger/IDiaSymbol--get_typeId.md)|`DWORD`|ID of the type symbol.|  
|[IDiaSymbol::get_unalignedType](../VS_debugger/IDiaSymbol--get_unalignedType.md)|`BOOL`|`TRUE` if the pointer is unaligned.|  
|[IDiaSymbol::get_volatileType](../VS_debugger/IDiaSymbol--get_volatileType.md)|`BOOL`|`TRUE` if the pointer is marked as volatile.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../VS_debugger/Class-Hierarchy-of-Symbol-Types.md)