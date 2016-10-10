---
title: "Compiler Error CS1730"
ms.custom: na
ms.date: 10/01/2016
ms.devlang: 
  - CSharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 20900ca0-702f-4f35-9a60-2dee9cb11902
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
# Compiler Error CS1730
Assembly and module attributes must precede all other elements defined in a file except using clauses and extern alias declarations.  
  
 An attribute applied at the assembly level cannot appear after any type definitions.  
  
### To correct this error  
  
1.  Move the attribute to the top of the file, but below the `using` directives and `extern` alias declarations.  
  
## Example  
 The following code generates CS1730:  
  
```  
// cs1730.cs  
class Test  
{  
}  
[assembly: System.Attribute] // CS1730  
```  
  
## See Also  
 [Attributes](../Topic/Attributes%20\(C%23%20and%20Visual%20Basic\).md)