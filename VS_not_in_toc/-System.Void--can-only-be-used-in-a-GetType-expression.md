---
title: "&#39;System.Void&#39; can only be used in a GetType expression"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 84e45194-cb46-41f6-8420-a1498baeaaba
caps.latest.revision: 8
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
# &#39;System.Void&#39; can only be used in a GetType expression
An expression in an assignment statement or a declaration uses <xref:System.Void?qualifyHint=False> as the type of a variable, procedure parameter, function return, or type argument.  
  
 The <xref:System.Void?qualifyHint=False> structure is a specialized type used internally by the .NET Framework and particularly by Visual C# and Visual C++. It represents a return value type for a method that does not return a value. Visual Basic uses a `Sub` procedure when a value is not returned and a `Function` procedure when a value is returned.  
  
 You can test a reference variable with the [GetType Operator](../Topic/GetType%20Operator%20\(Visual%20Basic\).md) operator to see if its run-time type is <xref:System.Void?qualifyHint=False>, but you cannot use <xref:System.Void?qualifyHint=False> in any other context.  
  
 **Error ID:** BC31422  
  
### To correct this error  
  
1.  If you want to compare the run-time type of a variable to <xref:System.Void?qualifyHint=False>, use the `GetType` operator.  
  
2.  Unless you have a particular reason to compare a run-time type to <xref:System.Void?qualifyHint=False>, remove the reference to it altogether.  
  
## See Also  
 <xref:System.Void?qualifyHint=False>   
 [GetType Operator](../Topic/GetType%20Operator%20\(Visual%20Basic\).md)