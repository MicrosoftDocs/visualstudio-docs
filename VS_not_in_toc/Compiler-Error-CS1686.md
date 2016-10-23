---
title: "Compiler Error CS1686"
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
ms.assetid: 46a9e82b-57f4-416d-8e49-242bfff5433a
caps.latest.revision: 12
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
# Compiler Error CS1686
Local 'variable' or its members cannot have their address taken and be used inside an anonymous method or lambda expression  
  
 This error is generated when you use a variable, and attempt to take its address, and one of these actions is done inside an anonymous method.  
  
## Example  
 The following sample generates CS1686.  
  
```  
// CS1686.cs  
// compile with: /unsafe /target:library  
class MyClass  
{  
   public unsafe delegate int * MyDelegate();  
  
   public unsafe int * Test()  
   {  
      int j = 0;  
      MyDelegate d = delegate { return &j; };   // CS1686  
      return &j;   // OK  
   }  
}  
```