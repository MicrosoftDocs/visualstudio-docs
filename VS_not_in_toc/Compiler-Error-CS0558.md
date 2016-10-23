---
title: "Compiler Error CS0558"
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
ms.assetid: af63b9ba-2790-4362-a49d-b69a5292a555
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
# Compiler Error CS0558
User-defined operator 'operator' must be declared static and public  
  
 Both the **static** and **public** access [modifiers](../Topic/Modifiers%20\(C%23%20Reference\).md) must be specified on user-defined operators.  
  
 The following sample generates CS0558:  
  
```  
// CS0558.cs  
namespace x  
{  
   public class ii  
   {  
      public class iii  
      {  
         static implicit operator int(iii aa)   // CS0558, add public  
         {  
            return 0;  
         }  
      }  
  
      public static void Main()  
      {  
      }  
   }  
}  
```