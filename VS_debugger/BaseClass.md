---
title: "BaseClass"
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
ms.assetid: 9375ca35-cb91-45f5-8903-7344ee4528e8
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
# BaseClass
Each base class for a user-defined type (UDT) symbol is identified by a child with a `SymTagBaseClass` tag. The [IDiaSymbol::get_type](../VS_debugger/IDiaSymbol--get_type.md) property contains the symbol for the underlying UDT, and all properties of the underlying UDT are available as part of this BaseClass symbol.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_access](../VS_debugger/IDiaSymbol--get_access.md)|`DWORD`|Access modifier applied to this base class. One of the [CV_access_e Enumeration](../VS_debugger/CV_access_e.md) values.|  
|[IDiaSymbol::get_classParent](../VS_debugger/IDiaSymbol--get_classParent.md)|`IDiaSymbol*`|Symbol of the enclosing class (if any).|  
|[IDiaSymbol::get_classParentId](../VS_debugger/IDiaSymbol--get_classParentId.md)|`DWORD`|ID of the class parent symbol.|  
|[IDiaSymbol::get_constructor](../VS_debugger/IDiaSymbol--get_constructor.md)|`BOOL`|`TRUE` if the base class has a constructor.|  
|[IDiaSymbol::get_constType](../VS_debugger/IDiaSymbol--get_constType.md)|`BOOL`|`TRUE` if the base class is marked as const.|  
|[IDiaSymbol::get_hasAssignmentOperator](../VS_debugger/IDiaSymbol--get_hasAssignmentOperator.md)|`BOOL`|`TRUE` if the base class has an assignment operator.|  
|[IDiaSymbol::get_hasCastOperator](../VS_debugger/IDiaSymbol--get_hasCastOperator.md)|`BOOL`|`TRUE` if the base class has a cast operator.|  
|[IDiaSymbol::get_hasNestedTypes](../VS_debugger/IDiaSymbol--get_hasNestedTypes.md)|`BOOL`|`TRUE` if the base class has nested types.|  
|[IDiaSymbol::get_indirectVirtualBaseClass](../VS_debugger/IDiaSymbol--get_indirectVirtualBaseClass.md)|`BOOL`|`TRUE` if the base class is indirect.|  
|[IDiaSymbol::get_length](../VS_debugger/IDiaSymbol--get_length.md)|`DWORD`|Length of this base class in bytes.|  
|[IDiaSymbol::get_lexicalParent](../VS_debugger/IDiaSymbol--get_lexicalParent.md)|`IDiaSymbol*`|Symbol of the enclosing compiland.|  
|[IDiaSymbol::get_lexicalParentId](../VS_debugger/IDiaSymbol--get_lexicalParentId.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_name](../VS_debugger/IDiaSymbol--get_name.md)|`BSTR`|Name of the base class.|  
|[IDiaSymbol::get_nested](../VS_debugger/IDiaSymbol--get_nested.md)|`BOOL`|`TRUE` if the base class is nested.|  
|[IDiaSymbol::get_offset](../VS_debugger/IDiaSymbol--get_offset.md)|`LONG`|Offset of subobject that represents the base class within the structure.|  
|[IDiaSymbol::get_overloadedOperator](../VS_debugger/IDiaSymbol--get_overloadedOperator.md)|`BOOL`|`TRUE` if the base class has any overloaded operators.|  
|[IDiaSymbol::get_packed](../VS_debugger/IDiaSymbol--get_packed.md)|`BOOL`|`TRUE` if the base class is packed.|  
|[IDiaSymbol::get_scoped](../VS_debugger/IDiaSymbol--get_scoped.md)|`BOOL`|`TRUE` if the base class appears in a nonglobal scope.|  
|[IDiaSymbol::get_symIndexId](../VS_debugger/IDiaSymbol--get_symIndexId.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md)|`DWORD`|Returns `SymTagBaseClass` (one of the [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) values).|  
|[IDiaSymbol::get_type](../VS_debugger/IDiaSymbol--get_type.md)|`IDiaSymbol*`|The symbol for the base class [UDT](../VS_debugger/UDT.md).|  
|[IDiaSymbol::get_typeId](../VS_debugger/IDiaSymbol--get_typeId.md)|`DWORD`|ID of the type symbol.|  
|[IDiaSymbol::get_udtKind](../VS_debugger/IDiaSymbol--get_udtKind.md)|`DWORD`|A value from the [UdtKind Enumeration](../VS_debugger/UdtKind.md).|  
|[IDiaSymbol::get_unalignedType](../VS_debugger/IDiaSymbol--get_unalignedType.md)|`BOOL`|`TRUE` if the base class is unaligned.|  
|[IDiaSymbol::get_virtualBaseClass](../VS_debugger/IDiaSymbol--get_virtualBaseClass.md)|`BOOL`|`TRUE` if the base class is virtual.|  
|[IDiaSymbol::get_virtualBaseDispIndex](../VS_debugger/IDiaSymbol--get_virtualBaseDispIndex.md)|`DWORD`|Index into the virtual base displacement table.|  
|[IDiaSymbol::get_virtualBasePointerOffset](../VS_debugger/IDiaSymbol--get_virtualBasePointerOffset.md)|`LONG`|Offset of the virtual base pointer.|  
|[IDiaSymbol::get_virtualBaseTableType](../VS_debugger/IDiaSymbol--get_virtualBaseTableType.md)|`IDiaSymbol*`|The type of the virtual base table pointer.|  
|[IDiaSymbol::get_virtualTableShape](../VS_debugger/IDiaSymbol--get_virtualTableShape.md)|`IDiaSymbol*`|The symbol describing the type of the virtual table for this base class.|  
|[IDiaSymbol::get_virtualTableShapeId](../VS_debugger/IDiaSymbol--get_virtualTableShapeId.md)|`DWORD`|ID of the virtual table shape symbol.|  
|[IDiaSymbol::get_volatileType](../VS_debugger/IDiaSymbol--get_volatileType.md)|`BOOL`|`TRUE` if the base class is marked as volatile.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../VS_debugger/Class-Hierarchy-of-Symbol-Types.md)   
 [UDT](../VS_debugger/UDT.md)