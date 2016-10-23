---
title: "Troubleshooting Exceptions: System.DivideByZeroException"
ms.custom: na
ms.date: 10/01/2016
ms.devlang: 
  - JScript
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ddc79201-3ba1-455f-8496-edaad792ccf1
caps.latest.revision: 14
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
# Troubleshooting Exceptions: System.DivideByZeroException
A <xref:System.DivideByZeroException?qualifyHint=False> exception is thrown when there is an attempt to divide an integer or decimal value by zero.  
  
## Associated Tips  
 **Make sure the value of the denominator is not zero before you perform a division operation.**  
 Dividing a floating-point value by zero results in either positive infinity, negative infinity, or Not a Number (NaN), according to the rules of IEEE arithmetic. Floating-point operations never throw an exception.  
  
## See Also  
 <xref:System.DivideByZeroException?qualifyHint=False>   
 [Arithmetic Operators in Visual Basic](../Topic/Arithmetic%20Operators%20in%20Visual%20Basic.md)   
 [Use the Exception Assistant](../Topic/How%20to:%20Use%20the%20Exception%20Assistant.md)