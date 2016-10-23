---
title: "Compiler Warning (level 3) CS0219"
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
ms.assetid: 7945c497-4bfa-4695-9166-815a2ad0c8e7
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
# Compiler Warning (level 3) CS0219
The variable 'variable' is assigned but its value is never used  
  
 The compiler issues a level-three warning, when you declare and assign a variable, but do not use it.  
  
 The following sample generates CS0219:  
  
```  
// CS0219.cs  
// compile with: /W:3  
public class MyClass  
{  
   public static void Main()  
   {  
      int a = 0;   // CS0219  
   }  
}  
```