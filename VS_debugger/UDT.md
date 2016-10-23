---
title: "UDT"
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
ms.assetid: f12459dd-c64d-4cc9-9ee3-a56e19e9e573
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
# UDT
Each class, structure, and union is identified by a `SymTagUDT` symbol. Each member, function, data, or nested type, and each base class, appears as a class child of the user-defined type (UDT).  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_classParent](../VS_debugger/IDiaSymbol--get_classParent.md)|`IDiaSymbol*`|Symbol for the class parent, if any.|  
|[IDiaSymbol::get_classParentId](../VS_debugger/IDiaSymbol--get_classParentId.md)|`DWORD`|ID of the class parent symbol.|  
|[IDiaSymbol::get_constructor](../VS_debugger/IDiaSymbol--get_constructor.md)|`BOOL`|`TRUE` if the UDT has a constructor.|  
|[IDiaSymbol::get_constType](../VS_debugger/IDiaSymbol--get_constType.md)|`BOOL`|`TRUE` if the UDT is marked as constant.|  
|[IDiaSymbol::get_hasAssignmentOperator](../VS_debugger/IDiaSymbol--get_hasAssignmentOperator.md)|`BOOL`|`TRUE` if the UDT has any assignment operators defined.|  
|[IDiaSymbol::get_hasCastOperator](../VS_debugger/IDiaSymbol--get_hasCastOperator.md)|`BOOL`|`TRUE` if the UDT has any cast operators defined.|  
|[IDiaSymbol::get_hasNestedTypes](../VS_debugger/IDiaSymbol--get_hasNestedTypes.md)|`BOOL`|`TRUE` if the UDT has nested type definitions.|  
|[IDiaSymbol::get_length](../VS_debugger/IDiaSymbol--get_length.md)|`LONGLONG`|The size, in bytes, of the UDT.|  
|[IDiaSymbol::get_lexicalParent](../VS_debugger/IDiaSymbol--get_lexicalParent.md)|`IDiaSymbol*`|Symbol of the enclosing [Compiland](../VS_debugger/Compiland.md).|  
|[IDiaSymbol::get_lexicalParentId](../VS_debugger/IDiaSymbol--get_lexicalParentId.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_name](../VS_debugger/IDiaSymbol--get_name.md)|`BSTR`|The name of the UDT.|  
|[IDiaSymbol::get_nested](../VS_debugger/IDiaSymbol--get_nested.md)|`BOOL`|`TRUE` if the UDT is nested.|  
|[IDiaSymbol::get_overloadedOperator](../VS_debugger/IDiaSymbol--get_overloadedOperator.md)|`BOOL`|`TRUE` if overloaded operators are defined for the UDT.|  
|[IDiaSymbol::get_packed](../VS_debugger/IDiaSymbol--get_packed.md)|`BOOL`|`TRUE` if the UDT is packed.|  
|[IDiaSymbol::get_scoped](../VS_debugger/IDiaSymbol--get_scoped.md)|`BOOL`|`TRUE` if the UDT appears in a nonglobal lexical scope.|  
|[IDiaSymbol::get_symIndexId](../VS_debugger/IDiaSymbol--get_symIndexId.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md)|`DWORD`|Returns `SymTagUDT` (one of the [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) values).|  
|[IDiaSymbol::get_udtKind](../VS_debugger/IDiaSymbol--get_udtKind.md)|`DWORD`|Indicates whether this is a structure, class, or union; for details, see [UdtKind Enumeration](../VS_debugger/UdtKind.md).|  
|[IDiaSymbol::get_unalignedType](../VS_debugger/IDiaSymbol--get_unalignedType.md)|`BOOL`|`TRUE` if the UDT is unaligned.|  
|[IDiaSymbol::get_virtualTableShape](../VS_debugger/IDiaSymbol--get_virtualTableShape.md)|`IDiaSymbol*`|The type of the virtual table.|  
|[IDiaSymbol::get_virtualTableShapeId](../VS_debugger/IDiaSymbol--get_virtualTableShapeId.md)|`DWORD`|ID of the virtual table shape symbol.|  
|[IDiaSymbol::get_volatileType](../VS_debugger/IDiaSymbol--get_volatileType.md)|`BOOL`|`TRUE` if the UDT is marked as volatile.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../VS_debugger/Class-Hierarchy-of-Symbol-Types.md)