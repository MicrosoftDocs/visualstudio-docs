---
title: "Dimension"
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
ms.assetid: 94f791da-bfea-454f-8a14-da31e8e1596a
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
# Dimension
Each FORTRAN array has a dimension that is identified by a `SymTagDimension` symbol.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_lowerBound](../VS_debugger/IDiaSymbol--get_lowerBound.md)|`IDiaSymbol*`|Lower bound of a FORTRAN array dimension.|  
|[IDiaSymbol::get_lowerBoundId](../VS_debugger/IDiaSymbol--get_lowerBoundId.md)|`DWORD`|ID of the lower-bound symbol.|  
|[IDiaSymbol::get_symIndexId](../VS_debugger/IDiaSymbol--get_symIndexId.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md)|`DWORD`|Returns `SymTagDimension` (one of the [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) values).|  
|[IDiaSymbol::get_upperBound](../VS_debugger/IDiaSymbol--get_upperBound.md)|`IDiaSymbol*`|Upper bound of a FORTRAN array dimension.|  
|[IDiaSymbol::get_upperBoundId](../VS_debugger/IDiaSymbol--get_upperBoundId.md)|`DWORD`|ID of the upper-bound symbol.|  
  
## See Also  
 [ArrayType](../VS_debugger/ArrayType.md)   
 [Class Hierarchy of Symbol Types](../VS_debugger/Class-Hierarchy-of-Symbol-Types.md)