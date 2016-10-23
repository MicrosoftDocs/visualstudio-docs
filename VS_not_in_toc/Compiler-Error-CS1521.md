---
title: "Compiler Error CS1521"
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
ms.assetid: 9a482b33-24f2-4654-81b4-be40bf56d624
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
# Compiler Error CS1521
Invalid base type  
  
 A [base](../Topic/base%20\(C%23%20Reference\).md) class specification was ill formed.  
  
 The following sample generates CS1521:  
  
```  
// CS1521.cs  
class CMyClass  
{  
   public static void Main()  
   {  
   }  
}  
  
class CMyClass1 : CMyClass     // OK  
{  
}  
  
class CMyClass2 : CMyClass[]   // CS1521  
{  
}  
  
class CMyClass3 : CMyClass*    // CS1521  
{  
}  
```