---
title: "VTableShape | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "VTableShape symbol"
  - "SymTagVTableShape tag"
ms.assetid: dd97f4c3-115d-46a9-b506-2531e30a0d8f
caps.latest.revision: 20
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# VTableShape
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The [VTable](../../debugger/debug-interface-access/vtable.md) symbol has a class child symbol identified by the `SymTagVTableShape` tag.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_constType](../../debugger/debug-interface-access/idiasymbol-get-consttype.md)|`BOOL`|`TRUE` if the class of the VTable is marked as a constant.|  
|[IDiaSymbol::get_count](../../debugger/debug-interface-access/idiasymbol-get-count.md)|`DWORD`|Number of entries in the VTable.|  
|[IDiaSymbol::get_lexicalParent](../../debugger/debug-interface-access/idiasymbol-get-lexicalparent.md)|`IDiaSymbol*`|Symbol of the enclosing compiland.|  
|[IDiaSymbol::get_lexicalParentId](../../debugger/debug-interface-access/idiasymbol-get-lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_symIndexId](../../debugger/debug-interface-access/idiasymbol-get-symindexid.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../../debugger/debug-interface-access/idiasymbol-get-symtag.md)|`DWORD`|Returns `SymTagVTableShape` (one of the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) values).|  
|[IDiaSymbol::get_unalignedType](../../debugger/debug-interface-access/idiasymbol-get-unalignedtype.md)|`BOOL`|`TRUE` if the class of the VTable is unaligned.|  
|[IDiaSymbol::get_volatileType](../../debugger/debug-interface-access/idiasymbol-get-volatiletype.md)|`BOOL`|`TRUE` if the class of the VTable is marked as volatile.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../../debugger/debug-interface-access/class-hierarchy-of-symbol-types.md)   
 [VTable](../../debugger/debug-interface-access/vtable.md)
