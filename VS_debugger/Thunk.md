---
title: "Thunk"
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
ms.assetid: 01abb95f-d89a-465c-a4eb-8e8509598c95
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
# Thunk
Each `thunk` is identified by a `SymTagThunk` tag.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_access](../VS_debugger/IDiaSymbol--get_access.md)|`DWORD`|Access modifier attribute, one of the [CV_access_e Enumeration](../VS_debugger/CV_access_e.md) values (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_addressOffset](../VS_debugger/IDiaSymbol--get_addressOffset.md)|`DWORD`|Offset part of location; for details, see the [LocationType Enumeration](../VS_debugger/LocationType.md).|  
|[IDiaSegment::get_addressSection](../VS_debugger/IDiaSegment--get_addressSection.md)|`DWORD`|Section part of location; for details, see the [LocationType Enumeration](../VS_debugger/LocationType.md).|  
|[IDiaSymbol::get_classParent](../VS_debugger/IDiaSymbol--get_classParent.md)|`IDiaSymbol*`|Enclosing class parent, if any (only under DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_classParentId](../VS_debugger/IDiaSymbol--get_classParentId.md)|`DWORD`|ID of the enclosing class parent symbol (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_constType](../VS_debugger/IDiaSymbol--get_constType.md)|`BOOL`|TRUE if the thunk is marked as constant (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_intro](../VS_debugger/IDiaSymbol--get_intro.md)|`BOOL`|TRUE if the thunk is an introduction to a virtual function (only in DIA SDK V8.0 or later)|  
|[IDiaSymbol::get_isStatic](../VS_debugger/IDiaSymbol--get_isStatic.md)|`BOOL`|TRUE if the thunk is considered static (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_length](../VS_debugger/IDiaSymbol--get_length.md)|`ULONGLONG`|Number of bytes of code in the thunk.|  
|[IDiaSymbol::get_lexicalParent](../VS_debugger/IDiaSymbol--get_lexicalParent.md)|`IDiaSymbol*`|Symbol for the enclosing compiland, block, or function.|  
|[IDiaSymbol::get_lexicalParentId](../VS_debugger/IDiaSymbol--get_lexicalParentId.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_locationType](../VS_debugger/IDiaSymbol--get_locationType.md)|`DWORD`|End points have static location; for details, see [Symbol Locations](../VS_debugger/Symbol-Locations.md) enumeration.|  
|[IDiaSymbol::get_name](../VS_debugger/IDiaSymbol--get_name.md)|`BSTR`|Name of the thunk.|  
|[IDiaSymbol::get_pure](../VS_debugger/IDiaSymbol--get_pure.md)|`BOOL`|TRUE if the thunk is purely virtual (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_relativeVirtualAddress](../VS_debugger/IDiaSymbol--get_relativeVirtualAddress.md)|`DWORD`|Relative position of this thunk within its module.|  
|[IDiaSymbol::get_symIndexId](../VS_debugger/IDiaSymbol--get_symIndexId.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md)|`DWORD`|Returns `SymTagThunk` (one of the [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) values).|  
|[IDiaSymbol::get_targetOffset](../VS_debugger/IDiaSymbol--get_targetOffset.md)|`DWORD`|Offset part of location of the thunk target.|  
|[IDiaSymbol::get_targetRelativeVirtualAddress](../VS_debugger/IDiaSymbol--get_targetRelativeVirtualAddress.md)|`DWORD`|Relative virtual address of the thunk target in its enclosing block.|  
|[IDiaSymbol::get_targetSection](../VS_debugger/IDiaSymbol--get_targetSection.md)|`DWORD`|Section part of the thunk target.|  
|[IDiaSymbol::get_targetVirtualAddress](../VS_debugger/IDiaSymbol--get_targetVirtualAddress.md)|`ULONGLONG`|Position of the thunk target in the executable image.|  
|[IDiaSymbol::get_thunkOrdinal](../VS_debugger/IDiaSymbol--get_thunkOrdinal.md)|`DWORD`|Thunk type, as defined by the [THUNK_ORDINAL Enumeration](../VS_debugger/THUNK_ORDINAL.md).|  
|[IDiaSymbol::get_type](../VS_debugger/IDiaSymbol--get_type.md)|`IDiaSymbol*`|The type of this thunk (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_typeId](../VS_debugger/IDiaSymbol--get_typeId.md)|`DWORD`|ID of the type symbol (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_unalignedType](../VS_debugger/IDiaSymbol--get_unalignedType.md)|`BOOL`|`TRUE` if the thunk is not aligned (only in DIA SDK V8.0 or later),|  
|[IDiaSymbol::get_virtual](../VS_debugger/IDiaSymbol--get_virtual.md)|`BOOL`|`TRUE` if the thunk is virtual (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_virtualAddress](../VS_debugger/IDiaSymbol--get_virtualAddress.md)|`ULONGLONG`|Position of this thunk within the executable image.|  
|[IDiaSymbol::get_virtualBaseOffset](../VS_debugger/IDiaSymbol--get_virtualBaseOffset.md)|`DWORD`|The offset in the virtual table to this thunk (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_volatileType](../VS_debugger/IDiaSymbol--get_volatileType.md)|`BOOL`|`TRUE` if the thunk is marked as volatile (only in DIA SDK V8.0 or later).|  
  
## See Also  
 [Lexical Hierarchy of Symbol Types](../VS_debugger/Lexical-Hierarchy-of-Symbol-Types.md)   
 [LocationType Enumeration](../VS_debugger/LocationType.md)   
 [THUNK_ORDINAL Enumeration](../VS_debugger/THUNK_ORDINAL.md)