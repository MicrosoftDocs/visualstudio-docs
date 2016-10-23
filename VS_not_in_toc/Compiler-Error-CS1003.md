---
title: "Compiler Error CS1003"
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
ms.assetid: 59f4d053-13c0-4f79-830e-263acdbe94fa
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
# Compiler Error CS1003
Syntax error, 'char' expected  
  
 The compiler will generate this error for any one of several error conditions. Review your code to find the syntax error.  
  
 The following sample generates CS1003:  
  
```  
// CS1003.cs  
public class b  
{  
   public static void Main()  
   {  
      int[] a;  
      a[);   // CS1003  
   }  
}  
```