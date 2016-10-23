---
title: "Enum (Debug Interface Access SDK)"
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
ms.assetid: c777e2e6-88be-435b-b632-8d43f42b0b49
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
# Enum (Debug Interface Access SDK)
Enumerations are identified by `SymTagEnum` symbols. Each enumeration value appears as a class child with a `SymTagConstant` tag.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_baseType](../VS_debugger/IDiaSymbol--get_baseType.md)|`DWORD`|One of the [BasicType Enumeration](../VS_debugger/BasicType.md) values.|  
|[IDiaSymbol::get_classParent](../VS_debugger/IDiaSymbol--get_classParent.md)|`IDiaSymbol*`|Class parent of this enumeration, if any.|  
|[IDiaSymbol::get_classParentId](../VS_debugger/IDiaSymbol--get_classParentId.md)|`DWORD`|ID of the class parent symbol.|  
|[IDiaSymbol::get_constructor](../VS_debugger/IDiaSymbol--get_constructor.md)|`BOOL`|`TRUE` if the enumeration has a constructor.|  
|[IDiaSymbol::get_constType](../VS_debugger/IDiaSymbol--get_constType.md)|`BOOL`|`TRUE` if the enumeration is marked as const.|  
|[IDiaSymbol::get_hasAssignmentOperator](../VS_debugger/IDiaSymbol--get_hasAssignmentOperator.md)|`BOOL`|`TRUE` if the enumeration has an assignment operator.|  
|[IDiaSymbol::get_hasCastOperator](../VS_debugger/IDiaSymbol--get_hasCastOperator.md)|`BOOL`|`TRUE` if the enumeration has a cast operator.|  
|[IDiaSymbol::get_hasNestedTypes](../VS_debugger/IDiaSymbol--get_hasNestedTypes.md)|`BOOL`|`TRUE` if the enumeration has nested types.|  
|[IDiaSymbol::get_length](../VS_debugger/IDiaSymbol--get_length.md)|`DWORD`|Length of this enumeration in bytes.|  
|[IDiaSymbol::get_lexicalParent](../VS_debugger/IDiaSymbol--get_lexicalParent.md)|`IDiaSymbol*`|Symbol of the enclosing [Compiland](../VS_debugger/Compiland.md).|  
|[IDiaSymbol::get_lexicalParentId](../VS_debugger/IDiaSymbol--get_lexicalParentId.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_name](../VS_debugger/IDiaSymbol--get_name.md)|`BSTR`|Name of the enumerated type.|  
|[IDiaSymbol::get_nested](../VS_debugger/IDiaSymbol--get_nested.md)|`BOOL`|`TRUE` if the enumeration is nested.|  
|[IDiaSymbol::get_overloadedOperator](../VS_debugger/IDiaSymbol--get_overloadedOperator.md)|`BOOL`|`TRUE` if the enumeration has any overloaded operators.|  
|[IDiaSymbol::get_packed](../VS_debugger/IDiaSymbol--get_packed.md)|`BOOL`|`TRUE` if the enumeration is packed.|  
|[IDiaSymbol::get_scoped](../VS_debugger/IDiaSymbol--get_scoped.md)|`BOOL`|`TRUE` if the enumeration appears in a nonglobal lexical scope.|  
|[IDiaSymbol::get_symIndexId](../VS_debugger/IDiaSymbol--get_symIndexId.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md)|`DWORD`|Returns `SymTagEnum` (one of the [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) values).|  
|[IDiaSymbol::get_type](../VS_debugger/IDiaSymbol--get_type.md)|`IDiaSymbol*`|Symbol for the underlying type.|  
|[IDiaSymbol::get_typeId](../VS_debugger/IDiaSymbol--get_typeId.md)|`DWORD`|ID of the type symbol.|  
|[IDiaSymbol::get_unalignedType](../VS_debugger/IDiaSymbol--get_unalignedType.md)|`BOOL`|`TRUE` if the enumeration is unaligned.|  
|[IDiaSymbol::get_volatileType](../VS_debugger/IDiaSymbol--get_volatileType.md)|`BOOL`|`TRUE` if the enumeration is marked as volatile.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../VS_debugger/Class-Hierarchy-of-Symbol-Types.md)