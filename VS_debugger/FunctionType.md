---
title: "FunctionType"
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
ms.assetid: 646a07e7-9d4f-4e21-95e3-3e403cdd4843
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
# FunctionType
Each unique function signature is identified by a `SymTagFunctionType` symbol. Each parameter is identified as a class child symbol with a `SymTagFunctionArgType` tag.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_callingConvention](../VS_debugger/IDiaSymbol--get_callingConvention.md)|`DWORD`|One of the values of the [CV_call_e Enumeration](../VS_debugger/CV_call_e.md).|  
|[IDiaSymbol::get_classParent](../VS_debugger/IDiaSymbol--get_classParent.md)|`IDiaSymbol*`|Class that this function (or method) is a member of.|  
|[IDiaSymbol::get_classParentId](../VS_debugger/IDiaSymbol--get_classParentId.md)|`DWORD`|ID of the class parent symbol.|  
|[IDiaSymbol::get_constType](../VS_debugger/IDiaSymbol--get_constType.md)|`BOOL`|`TRUE` if the function is marked as constant.|  
|[IDiaSymbol::get_count](../VS_debugger/IDiaSymbol--get_count.md)|`DWORD`|Number of function parameters.|  
|[IDiaSymbol::get_lexicalParent](../VS_debugger/IDiaSymbol--get_lexicalParent.md)|`IDiaSymbol*`|Symbol of the enclosing compiland.|  
|[IDiaSymbol::get_lexicalParentId](../VS_debugger/IDiaSymbol--get_lexicalParentId.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_objectPointerType](../VS_debugger/IDiaSymbol--get_objectPointerType.md)|`IDiaSymbol*`|Type of the method's object pointer ("this").|  
|[IDiaSymbol::get_symIndexId](../VS_debugger/IDiaSymbol--get_symIndexId.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md)|`DWORD`|Returns `SymTagFunctionType` (one of the [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) values).|  
|[IDiaSymbol::get_thisAdjust](../VS_debugger/IDiaSymbol--get_thisAdjust.md)|`LONG`|Logical "this" adjustor for the method.|  
|[IDiaSymbol::get_type](../VS_debugger/IDiaSymbol--get_type.md)|`IDiaSymbol*`|Symbol for the return value type.|  
|[IDiaSymbol::get_typeId](../VS_debugger/IDiaSymbol--get_typeId.md)|`DWORD`|ID of the type symbol.|  
|[IDiaSymbol::get_unalignedType](../VS_debugger/IDiaSymbol--get_unalignedType.md)|`BOOL`|`TRUE` if the function is unaligned.|  
|[IDiaSymbol::get_volatileType](../VS_debugger/IDiaSymbol--get_volatileType.md)|`BOOL`|`TRUE` if the function is marked as volatile.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../VS_debugger/Class-Hierarchy-of-Symbol-Types.md)   
 [CV_access_e Enumeration](../VS_debugger/CV_access_e.md)   
 [FunctionArgType](../VS_debugger/FunctionArgType.md)