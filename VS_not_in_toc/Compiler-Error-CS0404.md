---
title: "Compiler Error CS0404"
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
ms.assetid: 60bef49e-e0b7-4e9e-aab3-7afc20a19cb8
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
# Compiler Error CS0404
'<' unexpected : attributes cannot be generic  
  
 Generic type parameters are not allowed in attributes. Remove the type parameter and angled brackets.  
  
 The following sample generates CS0404:  
  
```  
// CS0404.cs  
[MyAttrib<int>]  // CS0404  
class C  
{  
   public static void Main()  
   {  
  
   }  
}  
```