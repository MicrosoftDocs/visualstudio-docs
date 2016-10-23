---
title: "FunctionArgType"
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
ms.assetid: 9f072fd3-0b99-405c-af99-fd44cd56fd73
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
# FunctionArgType
Each parameter of a function is identified by a `SymTagFunctionArgType` symbol.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_classParent](../VS_debugger/IDiaSymbol--get_classParent.md)|`IDiaSymbol*`|Symbol for the FunctionType parent.|  
|[IDiaSymbol::get_classParentId](../VS_debugger/IDiaSymbol--get_classParentId.md)|`DWORD`|ID of the class parent symbol.|  
|[IDiaSymbol::get_lexicalParent](../VS_debugger/IDiaSymbol--get_lexicalParent.md)|`IDiaSymbol*`|Symbol of the enclosing [Compiland](../VS_debugger/Compiland.md).|  
|[IDiaSymbol::get_lexicalParentId](../VS_debugger/IDiaSymbol--get_lexicalParentId.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_symIndexId](../VS_debugger/IDiaSymbol--get_symIndexId.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md)|`DWORD`|Returns `SymTagFunctionArgType` (one of the [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) values).|  
|[IDiaSymbol::get_type](../VS_debugger/IDiaSymbol--get_type.md)|`IDiaSymbol*`|Type of the parameter.|  
|[IDiaSymbol::get_typeId](../VS_debugger/IDiaSymbol--get_typeId.md)|`DWORD`|ID of the type symbol.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../VS_debugger/Class-Hierarchy-of-Symbol-Types.md)   
 [FunctionType](../VS_debugger/FunctionType.md)