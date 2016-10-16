---
title: "UDT"
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
  - "SymTagUDT symbol"
  - "user-defined type (UDT) symbol"
  - "unions, as symbols"
  - "UDT symbol"
  - "structs [C++]"
ms.assetid: f12459dd-c64d-4cc9-9ee3-a56e19e9e573
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
# UDT
Each class, structure, and union is identified by a `SymTagUDT` symbol. Each member, function, data, or nested type, and each base class, appears as a class child of the user-defined type (UDT).  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_classParent](../debugger/idiasymbol--get_classparent.md)|`IDiaSymbol*`|Symbol for the class parent, if any.|  
|[IDiaSymbol::get_classParentId](../debugger/idiasymbol--get_classparentid.md)|`DWORD`|ID of the class parent symbol.|  
|[IDiaSymbol::get_constructor](../debugger/idiasymbol--get_constructor.md)|`BOOL`|`TRUE` if the UDT has a constructor.|  
|[IDiaSymbol::get_constType](../debugger/idiasymbol--get_consttype.md)|`BOOL`|`TRUE` if the UDT is marked as constant.|  
|[IDiaSymbol::get_hasAssignmentOperator](../debugger/idiasymbol--get_hasassignmentoperator.md)|`BOOL`|`TRUE` if the UDT has any assignment operators defined.|  
|[IDiaSymbol::get_hasCastOperator](../debugger/idiasymbol--get_hascastoperator.md)|`BOOL`|`TRUE` if the UDT has any cast operators defined.|  
|[IDiaSymbol::get_hasNestedTypes](../debugger/idiasymbol--get_hasnestedtypes.md)|`BOOL`|`TRUE` if the UDT has nested type definitions.|  
|[IDiaSymbol::get_length](../debugger/idiasymbol--get_length.md)|`LONGLONG`|The size, in bytes, of the UDT.|  
|[IDiaSymbol::get_lexicalParent](../debugger/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol of the enclosing [Compiland](../debugger/compiland.md).|  
|[IDiaSymbol::get_lexicalParentId](../debugger/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_name](../debugger/idiasymbol--get_name.md)|`BSTR`|The name of the UDT.|  
|[IDiaSymbol::get_nested](../debugger/idiasymbol--get_nested.md)|`BOOL`|`TRUE` if the UDT is nested.|  
|[IDiaSymbol::get_overloadedOperator](../debugger/idiasymbol--get_overloadedoperator.md)|`BOOL`|`TRUE` if overloaded operators are defined for the UDT.|  
|[IDiaSymbol::get_packed](../debugger/idiasymbol--get_packed.md)|`BOOL`|`TRUE` if the UDT is packed.|  
|[IDiaSymbol::get_scoped](../debugger/idiasymbol--get_scoped.md)|`BOOL`|`TRUE` if the UDT appears in a nonglobal lexical scope.|  
|[IDiaSymbol::get_symIndexId](../debugger/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../debugger/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagUDT` (one of the [SymTagEnum Enumeration](../debugger/symtagenum.md) values).|  
|[IDiaSymbol::get_udtKind](../debugger/idiasymbol--get_udtkind.md)|`DWORD`|Indicates whether this is a structure, class, or union; for details, see [UdtKind Enumeration](../debugger/udtkind.md).|  
|[IDiaSymbol::get_unalignedType](../debugger/idiasymbol--get_unalignedtype.md)|`BOOL`|`TRUE` if the UDT is unaligned.|  
|[IDiaSymbol::get_virtualTableShape](../debugger/idiasymbol--get_virtualtableshape.md)|`IDiaSymbol*`|The type of the virtual table.|  
|[IDiaSymbol::get_virtualTableShapeId](../debugger/idiasymbol--get_virtualtableshapeid.md)|`DWORD`|ID of the virtual table shape symbol.|  
|[IDiaSymbol::get_volatileType](../debugger/idiasymbol--get_volatiletype.md)|`BOOL`|`TRUE` if the UDT is marked as volatile.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../debugger/class-hierarchy-of-symbol-types.md)