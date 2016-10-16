---
title: "Thunk"
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
  - "thunk properties [DIA SDK]"
  - "thunk symbol"
ms.assetid: 01abb95f-d89a-465c-a4eb-8e8509598c95
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
# Thunk
Each `thunk` is identified by a `SymTagThunk` tag.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_access](../debugger/idiasymbol--get_access.md)|`DWORD`|Access modifier attribute, one of the [CV_access_e Enumeration](../debugger/cv_access_e.md) values (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_addressOffset](../debugger/idiasymbol--get_addressoffset.md)|`DWORD`|Offset part of location; for details, see the [LocationType Enumeration](../debugger/locationtype.md).|  
|[IDiaSegment::get_addressSection](../debugger/idiasegment--get_addresssection.md)|`DWORD`|Section part of location; for details, see the [LocationType Enumeration](../debugger/locationtype.md).|  
|[IDiaSymbol::get_classParent](../debugger/idiasymbol--get_classparent.md)|`IDiaSymbol*`|Enclosing class parent, if any (only under DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_classParentId](../debugger/idiasymbol--get_classparentid.md)|`DWORD`|ID of the enclosing class parent symbol (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_constType](../debugger/idiasymbol--get_consttype.md)|`BOOL`|TRUE if the thunk is marked as constant (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_intro](../debugger/idiasymbol--get_intro.md)|`BOOL`|TRUE if the thunk is an introduction to a virtual function (only in DIA SDK V8.0 or later)|  
|[IDiaSymbol::get_isStatic](../debugger/idiasymbol--get_isstatic.md)|`BOOL`|TRUE if the thunk is considered static (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_length](../debugger/idiasymbol--get_length.md)|`ULONGLONG`|Number of bytes of code in the thunk.|  
|[IDiaSymbol::get_lexicalParent](../debugger/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol for the enclosing compiland, block, or function.|  
|[IDiaSymbol::get_lexicalParentId](../debugger/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_locationType](../debugger/idiasymbol--get_locationtype.md)|`DWORD`|End points have static location; for details, see [Symbol Locations](../debugger/symbol-locations.md) enumeration.|  
|[IDiaSymbol::get_name](../debugger/idiasymbol--get_name.md)|`BSTR`|Name of the thunk.|  
|[IDiaSymbol::get_pure](../debugger/idiasymbol--get_pure.md)|`BOOL`|TRUE if the thunk is purely virtual (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_relativeVirtualAddress](../debugger/idiasymbol--get_relativevirtualaddress.md)|`DWORD`|Relative position of this thunk within its module.|  
|[IDiaSymbol::get_symIndexId](../debugger/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../debugger/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagThunk` (one of the [SymTagEnum Enumeration](../debugger/symtagenum.md) values).|  
|[IDiaSymbol::get_targetOffset](../debugger/idiasymbol--get_targetoffset.md)|`DWORD`|Offset part of location of the thunk target.|  
|[IDiaSymbol::get_targetRelativeVirtualAddress](../debugger/idiasymbol--get_targetrelativevirtualaddress.md)|`DWORD`|Relative virtual address of the thunk target in its enclosing block.|  
|[IDiaSymbol::get_targetSection](../debugger/idiasymbol--get_targetsection.md)|`DWORD`|Section part of the thunk target.|  
|[IDiaSymbol::get_targetVirtualAddress](../debugger/idiasymbol--get_targetvirtualaddress.md)|`ULONGLONG`|Position of the thunk target in the executable image.|  
|[IDiaSymbol::get_thunkOrdinal](../debugger/idiasymbol--get_thunkordinal.md)|`DWORD`|Thunk type, as defined by the [THUNK_ORDINAL Enumeration](../debugger/thunk_ordinal.md).|  
|[IDiaSymbol::get_type](../debugger/idiasymbol--get_type.md)|`IDiaSymbol*`|The type of this thunk (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_typeId](../debugger/idiasymbol--get_typeid.md)|`DWORD`|ID of the type symbol (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_unalignedType](../debugger/idiasymbol--get_unalignedtype.md)|`BOOL`|`TRUE` if the thunk is not aligned (only in DIA SDK V8.0 or later),|  
|[IDiaSymbol::get_virtual](../debugger/idiasymbol--get_virtual.md)|`BOOL`|`TRUE` if the thunk is virtual (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_virtualAddress](../debugger/idiasymbol--get_virtualaddress.md)|`ULONGLONG`|Position of this thunk within the executable image.|  
|[IDiaSymbol::get_virtualBaseOffset](../debugger/idiasymbol--get_virtualbaseoffset.md)|`DWORD`|The offset in the virtual table to this thunk (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_volatileType](../debugger/idiasymbol--get_volatiletype.md)|`BOOL`|`TRUE` if the thunk is marked as volatile (only in DIA SDK V8.0 or later).|  
  
## See Also  
 [Lexical Hierarchy of Symbol Types](../debugger/lexical-hierarchy-of-symbol-types.md)   
 [LocationType Enumeration](../debugger/locationtype.md)   
 [THUNK_ORDINAL Enumeration](../debugger/thunk_ordinal.md)