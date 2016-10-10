---
title: "The type &#39;&lt;typename&gt;&#39; cannot be an array element type, return type, field type, generics argument type, &#39;ByRef&#39; parameter type or the type of an expression converted to &#39;Object&#39; or &#39;ValueType&#39;"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 56998a2c-a705-482e-87ee-5eff707f8a48
caps.latest.revision: 10
manager: douge
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
# The type &#39;&lt;typename&gt;&#39; cannot be an array element type, return type, field type, generics argument type, &#39;ByRef&#39; parameter type or the type of an expression converted to &#39;Object&#39; or &#39;ValueType&#39;
An expression declares a variable, procedure parameter, type parameter, function return, or array to be of a restricted type.  
  
 The common language runtime (CLR) exposes certain types solely for special language support, and they should not be used as data types in your application. These types include the <xref:System.ArgIterator?qualifyHint=False>, <xref:System.RuntimeArgumentHandle?qualifyHint=False>, and <xref:System.TypedReference?qualifyHint=False> structures.  
  
 **Error ID:** BC31396  
  
### To correct this error  
  
-   Do not use the restricted structure as a declared data type.  
  
## See Also  
 <xref:System.ArgIterator?qualifyHint=False>   
 <xref:System.RuntimeArgumentHandle?qualifyHint=False>   
 <xref:System.TypedReference?qualifyHint=False>