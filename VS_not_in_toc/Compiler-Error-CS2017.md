---
title: "Compiler Error CS2017"
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
ms.assetid: 16fd0c3b-018f-4734-809d-8d98d05a254c
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
# Compiler Error CS2017
Cannot specify /main if building a module or library  
  
 You cannot specify a main entry point when you are building a [/target:library](../Topic/-target:library%20\(C%23%20Compiler%20Options\).md).  
  
 The following sample generates CS2017:  
  
```  
// CS2017.cs  
// compile with: /main:MyClass /target:library  
// CS2017 expected  
class MyClass  
{  
   public static void Main()  
   {  
   }  
}  
```