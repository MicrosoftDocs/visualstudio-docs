---
title: "Compiler Warning (level 3) CS0665"
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
ms.assetid: bddff69b-e74e-45ce-8472-16ee53ae4609
caps.latest.revision: 7
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
# Compiler Warning (level 3) CS0665
Assignment in conditional expression is always constant; did you mean to use == instead of = ?  
  
 A conditional expression used the [= operator](../Topic/=%20Operator%20\(C%23%20Reference\).md) and not the [== operator](../Topic/==%20Operator%20\(C%23%20Reference\).md).  
  
 The following sample generates CS0665:  
  
```  
// CS0665.cs  
// compile with: /W:3  
class Test  
{  
   public static void Main()  
   {  
      bool i = false;  
  
      if (i = true)   // CS0665  
      // try the following line instead  
      // if (i == true)  
      {  
      }  
  
      System.Console.WriteLine(i);  
   }  
}  
```