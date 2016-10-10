---
title: "Compiler Error CS0500"
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
ms.assetid: b1a45708-702b-482c-bd71-c0c2531e29f3
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
# Compiler Error CS0500
'class member' cannot declare a body because it is marked abstract  
  
 An [abstract](../Topic/abstract%20\(C%23%20Reference\).md) method cannot contain its implementation.  
  
 The following sample generates CS0500:  
  
```  
// CS0500.cs  
namespace x  
{  
   abstract public class clx  
   {  
      abstract public void f(){}   // CS0500  
      // try the following line instead  
      // abstract public void f();  
   }  
  
   public class cly  
   {  
      public static int Main()  
      {  
         return 0;  
      }  
   }  
}  
```