---
title: "Compiler Error CS0677"
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
ms.assetid: 6a4a3703-9b44-4c4f-a564-8b437b1cb6b8
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
# Compiler Error CS0677
'variable': a volatile field cannot be of the type 'type'  
  
 Fields declared with the `volatile` keyword must be one of the following types:  
  
-   Any reference type  
  
-   Any pointer type (in an `unsafe` context)  
  
-   The types `sbyte`, **byte**, **short**, `ushort`, `int`, `uint`, `char`, **float**, `bool`  
  
-   Enum types based on any of the above types  
  
 The following sample generates CS0677:  
  
```  
// CS0677.cs  
class TestClass  
{  
   private volatile long i;   // CS0677  
  
   public static void Main()  
   {  
   }  
}  
```