---
title: "Type arguments inferred for method &#39;&lt;procedurename&gt;&#39; result in the following warnings :&lt;warninglist&gt;"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c789ffa9-0273-47f6-8915-78fc6a7d3d6d
caps.latest.revision: 6
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
# Type arguments inferred for method &#39;&lt;procedurename&gt;&#39; result in the following warnings :&lt;warninglist&gt;
A generic procedure is called without supplying any type arguments, and the inferred type arguments result in one or more warnings.  
  
 Normally, when you invoke a generic type, you supply a type argument for each type parameter that the generic type defines. If you do not supply any type arguments, the compiler attempts to infer the types to be passed to the type parameters. If the inferred types cause ambiguity, or if they create a situation that could lead to unexpected results, then the compiler generates this warning.  
  
 A *constraint* on a type parameter limits what type arguments can be passed to it. For example, a type parameter might be constrained to be a class that implements the <xref:System.IComparable`1?qualifyHint=False> interface. For more information, see "Constraints" in [Generic Procedures in Visual Basic](../Topic/Generic%20Procedures%20in%20Visual%20Basic.md).  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../VS_IDE/Configuring-Warnings-in-Visual-Basic.md).  
  
 **Error ID:** BC41006  
  
### To correct this error  
  
-   Supply type arguments to the generic procedure so that the compiler does not have to infer them.  
  
## See Also  
 [Generic Types in Visual Basic](../Topic/Generic%20Types%20in%20Visual%20Basic%20\(Visual%20Basic\).md)   
 [Generic Procedures in Visual Basic](../Topic/Generic%20Procedures%20in%20Visual%20Basic.md)   
 [Type List](../Topic/Type%20List%20\(Visual%20Basic\).md)