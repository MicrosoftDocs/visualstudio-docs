---
title: "Friend (Debug Interface Access SDK)"
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
  - "friend functions [DIA SDK]"
  - "friend classes [DIA SDK]"
  - "Friend symbol"
ms.assetid: 5147a170-41ce-4727-8ace-c318e8d11647
caps.latest.revision: 16
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
# Friend (Debug Interface Access SDK)
Friend classes and friend functions are identified by `SymTagFriend` symbols. They are children of parent user-defined types (UDTs) and have a [IDiaSymbol::get_classParent](../debugger/idiasymbol--get_classparent.md) property.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_classParent](../debugger/idiasymbol--get_classparent.md)|`IDiaSymbol*`|Symbol for the UDT parent.|  
|[IDiaSymbol::get_classParentId](../debugger/idiasymbol--get_classparentid.md)|`DWORD`|ID of the class parent symbol.|  
|[IDiaSymbol::get_name](../debugger/idiasymbol--get_name.md)|`BSTR`|Name of the class or function.|  
|[IDiaSymbol::get_symIndexId](../debugger/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../debugger/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagFriend` (one of the [SymTagEnum Enumeration](../debugger/symtagenum.md) values).|  
|[IDiaSymbol::get_type](../debugger/idiasymbol--get_type.md)|`IDiaSymbol*`|Symbol for the class or function.|  
|[IDiaSymbol::get_typeId](../debugger/idiasymbol--get_typeid.md)|`DWORD`|ID of the type symbol.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../debugger/class-hierarchy-of-symbol-types.md)