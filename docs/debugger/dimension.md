---
title: "Dimension"
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
  - "Dimension Symbol"
ms.assetid: 94f791da-bfea-454f-8a14-da31e8e1596a
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
# Dimension
Each FORTRAN array has a dimension that is identified by a `SymTagDimension` symbol.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_lowerBound](../debugger/idiasymbol--get_lowerbound.md)|`IDiaSymbol*`|Lower bound of a FORTRAN array dimension.|  
|[IDiaSymbol::get_lowerBoundId](../debugger/idiasymbol--get_lowerboundid.md)|`DWORD`|ID of the lower-bound symbol.|  
|[IDiaSymbol::get_symIndexId](../debugger/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../debugger/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagDimension` (one of the [SymTagEnum Enumeration](../debugger/symtagenum.md) values).|  
|[IDiaSymbol::get_upperBound](../debugger/idiasymbol--get_upperbound.md)|`IDiaSymbol*`|Upper bound of a FORTRAN array dimension.|  
|[IDiaSymbol::get_upperBoundId](../debugger/idiasymbol--get_upperboundid.md)|`DWORD`|ID of the upper-bound symbol.|  
  
## See Also  
 [ArrayType](../debugger/arraytype.md)   
 [Class Hierarchy of Symbol Types](../debugger/class-hierarchy-of-symbol-types.md)