---
title: "Compiler Error CS1534"
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
ms.assetid: afb28c3a-a74c-4e47-b016-9e3245a5a1b1
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
# Compiler Error CS1534
Overloaded binary operator 'operator' takes two parameters  
  
 The definition of a binary [overloadable operator](../Topic/Overloadable%20Operators%20\(C%23%20Programming%20Guide\).md) must take two parameters.  
  
 The following sample generates CS1534:  
  
```  
// CS1534.cs  
class MyClass  
{  
   public static MyClass operator - (MyClass MC1, MyClass MC2, MyClass MC3)   // CS1534  
   // try the following line instead  
   // public static MyClass operator - (MyClass MC1, MyClass MC2)  
   {  
      return new MyClass();  
   }  
  
   public static int Main()  
   {  
      return 1;  
   }  
}  
```