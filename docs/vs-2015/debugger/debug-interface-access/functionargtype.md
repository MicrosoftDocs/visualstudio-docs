---
title: "FunctionArgType | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FunctionArgType symbol"
ms.assetid: 9f072fd3-0b99-405c-af99-fd44cd56fd73
caps.latest.revision: 18
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# FunctionArgType
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Each parameter of a function is identified by a `SymTagFunctionArgType` symbol.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_classParent](../../debugger/debug-interface-access/idiasymbol-get-classparent.md)|`IDiaSymbol*`|Symbol for the FunctionType parent.|  
|[IDiaSymbol::get_classParentId](../../debugger/debug-interface-access/idiasymbol-get-classparentid.md)|`DWORD`|ID of the class parent symbol.|  
|[IDiaSymbol::get_lexicalParent](../../debugger/debug-interface-access/idiasymbol-get-lexicalparent.md)|`IDiaSymbol*`|Symbol of the enclosing [Compiland](../../debugger/debug-interface-access/compiland.md).|  
|[IDiaSymbol::get_lexicalParentId](../../debugger/debug-interface-access/idiasymbol-get-lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_symIndexId](../../debugger/debug-interface-access/idiasymbol-get-symindexid.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../../debugger/debug-interface-access/idiasymbol-get-symtag.md)|`DWORD`|Returns `SymTagFunctionArgType` (one of the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) values).|  
|[IDiaSymbol::get_type](../../debugger/debug-interface-access/idiasymbol-get-type.md)|`IDiaSymbol*`|Type of the parameter.|  
|[IDiaSymbol::get_typeId](../../debugger/debug-interface-access/idiasymbol-get-typeid.md)|`DWORD`|ID of the type symbol.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../../debugger/debug-interface-access/class-hierarchy-of-symbol-types.md)   
 [FunctionType](../../debugger/debug-interface-access/functiontype.md)
