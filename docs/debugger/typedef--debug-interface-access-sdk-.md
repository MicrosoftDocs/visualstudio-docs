---
title: "Typedef (Debug Interface Access SDK)"
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
  - "Typedef symbol [DIA SDK]"
ms.assetid: 9ab441b9-cc72-47fa-83e2-87b3c2b891b4
caps.latest.revision: 15
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
# Typedef (Debug Interface Access SDK)
Symbols with `SymTagTypedef` tags introduce names for other types.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_baseType](../debugger/idiasymbol--get_basetype.md)|`DWORD`|One of the [BasicType Enumeration](../debugger/basictype.md) values.|  
|[IDiaSymbol::get_classParent](../debugger/idiasymbol--get_classparent.md)|`IDiaSymbol*`|Class parent of this typedef, if any.|  
|[IDiaSymbol::get_classParentId](../debugger/idiasymbol--get_classparentid.md)|`DWORD`|ID of the class parent symbol.|  
|[IDiaSymbol::get_constructor](../debugger/idiasymbol--get_constructor.md)|`BOOL`|`TRUE` if this typedef has a constructor.|  
|[IDiaSymbol::get_constType](../debugger/idiasymbol--get_consttype.md)|`BOOL`|`TRUE` if this typedef is marked as constant.|  
|[IDiaSymbol::get_hasAssignmentOperator](../debugger/idiasymbol--get_hasassignmentoperator.md)|`BOOL`|`TRUE` if this typedef has an assignment operator.|  
|[IDiaSymbol::get_hasCastOperator](../debugger/idiasymbol--get_hascastoperator.md)|`BOOL`|`TRUE` if this typedef has a cast operator.|  
|[IDiaSymbol::get_hasNestedTypes](../debugger/idiasymbol--get_hasnestedtypes.md)|`BOOL`|`TRUE` if this typedef has nested types.|  
|[IDiaSymbol::get_length](../debugger/idiasymbol--get_length.md)|`ULONGLONG`|Length of this typedef in bytes.|  
|[IDiaSymbol::get_lexicalParent](../debugger/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol of the enclosing compiland.|  
|[IDiaSymbol::get_lexicalParentId](../debugger/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_name](../debugger/idiasymbol--get_name.md)|`BSTR`|Name of the typedef.|  
|[IDiaSymbol::get_nested](../debugger/idiasymbol--get_nested.md)|`BOOL`|`TRUE` if this typedef is nested in a lexical scope.|  
|[IDiaSymbol::get_overloadedOperator](../debugger/idiasymbol--get_overloadedoperator.md)|`BOOL`|`TRUE` if this typedef has an overloaded operator.|  
|[IDiaSymbol::get_packed](../debugger/idiasymbol--get_packed.md)|`BOOL`|`TRUE` if this typedef is packed.|  
|[IDiaSymbol::get_reference](../debugger/idiasymbol--get_reference.md)|`BOOL`|`TRUE` if this typedef is a reference.|  
|[IDiaSymbol::get_scoped](../debugger/idiasymbol--get_scoped.md)|`BOOL`|`TRUE` if this typedef is in a nonglobal lexical scope.|  
|[IDiaSymbol::get_symIndexId](../debugger/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../debugger/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagTypedef` (one of the [SymTagEnum Enumeration](../debugger/symtagenum.md) values).|  
|[IDiaSymbol::get_type](../debugger/idiasymbol--get_type.md)|`IDiaSymbol*`|Symbol for the underlying type.|  
|[IDiaSymbol::get_typeId](../debugger/idiasymbol--get_typeid.md)|`DWORD`|ID of the type symbol.|  
|[IDiaSymbol::get_udtKind](../debugger/idiasymbol--get_udtkind.md)|`DWORD`|One of the [UdtKind Enumeration](../debugger/udtkind.md) values.|  
|[IDiaSymbol::get_unalignedType](../debugger/idiasymbol--get_unalignedtype.md)|`BOOL`|`TRUE` if this typedef is not aligned.|  
|[IDiaSymbol::get_virtualTableShape](../debugger/idiasymbol--get_virtualtableshape.md)|`IDiaSymbol*`|The symbol that describes the virtual table shape.|  
|[IDiaSymbol::get_virtualTableShapeId](../debugger/idiasymbol--get_virtualtableshapeid.md)|`DWORD`|ID of the virtual table shape symbol.|  
|[IDiaSymbol::get_volatileType](../debugger/idiasymbol--get_volatiletype.md)|`BOOL`|`TRUE` if this typedef is marked as volatile.|  
  
## Remarks  
 Since a typedef can represent a class, pointer, or user-defined type (UDT), the symbol for a typedef shares the same properties as one of those other types of symbols.  
  
## See Also  
 [Class Hierarchy of Symbol Types](../debugger/class-hierarchy-of-symbol-types.md)