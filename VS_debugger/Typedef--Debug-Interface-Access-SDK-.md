---
title: "Typedef (Debug Interface Access SDK)"
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
ms.assetid: 9ab441b9-cc72-47fa-83e2-87b3c2b891b4
caps.latest.revision: 15
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
# Typedef (Debug Interface Access SDK)
Symbols with `SymTagTypedef` tags introduce names for other types.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_baseType](../VS_debugger/IDiaSymbol--get_baseType.md)|`DWORD`|One of the [BasicType Enumeration](../VS_debugger/BasicType.md) values.|  
|[IDiaSymbol::get_classParent](../VS_debugger/IDiaSymbol--get_classParent.md)|`IDiaSymbol*`|Class parent of this typedef, if any.|  
|[IDiaSymbol::get_classParentId](../VS_debugger/IDiaSymbol--get_classParentId.md)|`DWORD`|ID of the class parent symbol.|  
|[IDiaSymbol::get_constructor](../VS_debugger/IDiaSymbol--get_constructor.md)|`BOOL`|`TRUE` if this typedef has a constructor.|  
|[IDiaSymbol::get_constType](../VS_debugger/IDiaSymbol--get_constType.md)|`BOOL`|`TRUE` if this typedef is marked as constant.|  
|[IDiaSymbol::get_hasAssignmentOperator](../VS_debugger/IDiaSymbol--get_hasAssignmentOperator.md)|`BOOL`|`TRUE` if this typedef has an assignment operator.|  
|[IDiaSymbol::get_hasCastOperator](../VS_debugger/IDiaSymbol--get_hasCastOperator.md)|`BOOL`|`TRUE` if this typedef has a cast operator.|  
|[IDiaSymbol::get_hasNestedTypes](../VS_debugger/IDiaSymbol--get_hasNestedTypes.md)|`BOOL`|`TRUE` if this typedef has nested types.|  
|[IDiaSymbol::get_length](../VS_debugger/IDiaSymbol--get_length.md)|`ULONGLONG`|Length of this typedef in bytes.|  
|[IDiaSymbol::get_lexicalParent](../VS_debugger/IDiaSymbol--get_lexicalParent.md)|`IDiaSymbol*`|Symbol of the enclosing compiland.|  
|[IDiaSymbol::get_lexicalParentId](../VS_debugger/IDiaSymbol--get_lexicalParentId.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_name](../VS_debugger/IDiaSymbol--get_name.md)|`BSTR`|Name of the typedef.|  
|[IDiaSymbol::get_nested](../VS_debugger/IDiaSymbol--get_nested.md)|`BOOL`|`TRUE` if this typedef is nested in a lexical scope.|  
|[IDiaSymbol::get_overloadedOperator](../VS_debugger/IDiaSymbol--get_overloadedOperator.md)|`BOOL`|`TRUE` if this typedef has an overloaded operator.|  
|[IDiaSymbol::get_packed](../VS_debugger/IDiaSymbol--get_packed.md)|`BOOL`|`TRUE` if this typedef is packed.|  
|[IDiaSymbol::get_reference](../VS_debugger/IDiaSymbol--get_reference.md)|`BOOL`|`TRUE` if this typedef is a reference.|  
|[IDiaSymbol::get_scoped](../VS_debugger/IDiaSymbol--get_scoped.md)|`BOOL`|`TRUE` if this typedef is in a nonglobal lexical scope.|  
|[IDiaSymbol::get_symIndexId](../VS_debugger/IDiaSymbol--get_symIndexId.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md)|`DWORD`|Returns `SymTagTypedef` (one of the [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) values).|  
|[IDiaSymbol::get_type](../VS_debugger/IDiaSymbol--get_type.md)|`IDiaSymbol*`|Symbol for the underlying type.|  
|[IDiaSymbol::get_typeId](../VS_debugger/IDiaSymbol--get_typeId.md)|`DWORD`|ID of the type symbol.|  
|[IDiaSymbol::get_udtKind](../VS_debugger/IDiaSymbol--get_udtKind.md)|`DWORD`|One of the [UdtKind Enumeration](../VS_debugger/UdtKind.md) values.|  
|[IDiaSymbol::get_unalignedType](../VS_debugger/IDiaSymbol--get_unalignedType.md)|`BOOL`|`TRUE` if this typedef is not aligned.|  
|[IDiaSymbol::get_virtualTableShape](../VS_debugger/IDiaSymbol--get_virtualTableShape.md)|`IDiaSymbol*`|The symbol that describes the virtual table shape.|  
|[IDiaSymbol::get_virtualTableShapeId](../VS_debugger/IDiaSymbol--get_virtualTableShapeId.md)|`DWORD`|ID of the virtual table shape symbol.|  
|[IDiaSymbol::get_volatileType](../VS_debugger/IDiaSymbol--get_volatileType.md)|`BOOL`|`TRUE` if this typedef is marked as volatile.|  
  
## Remarks  
 Since a typedef can represent a class, pointer, or user-defined type (UDT), the symbol for a typedef shares the same properties as one of those other types of symbols.  
  
## See Also  
 [Class Hierarchy of Symbol Types](../VS_debugger/Class-Hierarchy-of-Symbol-Types.md)