---
title: "ArrayType | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ArrayType symbol"
ms.assetid: 1d973a3a-2bde-46df-8625-85d519bb3cc9
caps.latest.revision: 18
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# ArrayType
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

An array is identified by a `SymTagArray` symbol.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_arrayIndexType](../../debugger/debug-interface-access/idiasymbol-get-arrayindextype.md)|`IDiaSymbol*`|Symbol for the array index type.|  
|[IDiaSymbol::get_arrayIndexTypeId](../../debugger/debug-interface-access/idiasymbol-get-arrayindextypeid.md)|`DWORD`|ID of the array index type symbol.|  
|[IDiaSymbol::get_constType](../../debugger/debug-interface-access/idiasymbol-get-consttype.md)|`BOOL`|`TRUE` if the array is marked as const.|  
|[IDiaSymbol::get_count](../../debugger/debug-interface-access/idiasymbol-get-count.md)|`DWORD`|Number of items in the array.|  
|[IDiaSymbol::get_length](../../debugger/debug-interface-access/idiasymbol-get-length.md)|`LONGLONG`|Size, in bytes, of this array.|  
|[IDiaSymbol::get_lexicalParent](../../debugger/debug-interface-access/idiasymbol-get-lexicalparent.md)|`IDiaSymbol*`|Symbol of the enclosing compiland.|  
|[IDiaSymbol::get_lexicalParentId](../../debugger/debug-interface-access/idiasymbol-get-lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_rank](../../debugger/debug-interface-access/idiasymbol-get-rank.md)|`DWORD`|Rank of a FORTRAN multidimensional array.|  
|[IDiaSymbol::get_symIndexId](../../debugger/debug-interface-access/idiasymbol-get-symindexid.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../../debugger/debug-interface-access/idiasymbol-get-symtag.md)|`DWORD`|Returns `SymTagArray` (one of the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) values).|  
|[IDiaSymbol::get_type](../../debugger/debug-interface-access/idiasymbol-get-type.md)|`IDiaSymbol*`|Symbol for the array element type.|  
|[IDiaSymbol::get_typeId](../../debugger/debug-interface-access/idiasymbol-get-typeid.md)|`DWORD`|ID of the array element type symbol.|  
|[IDiaSymbol::get_unalignedType](../../debugger/debug-interface-access/idiasymbol-get-unalignedtype.md)|`BOOL`|`TRUE` if the array is unaligned|  
|[IDiaSymbol::get_volatileType](../../debugger/debug-interface-access/idiasymbol-get-volatiletype.md)|`BOOL`|`TRUE` if the array is marked as volatile.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../../debugger/debug-interface-access/class-hierarchy-of-symbol-types.md)   
 [Dimension](../../debugger/debug-interface-access/dimension.md)
