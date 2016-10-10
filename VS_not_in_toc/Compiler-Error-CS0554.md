---
title: "Compiler Error CS0554"
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
ms.assetid: 884db4b2-3a69-4434-9a25-526f596e03c8
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
# Compiler Error CS0554
'conversion routine' : user defined conversion to/from derived class  
  
 User-defined conversions to values of a derived class are not allowed; you do not need such an operator.  
  
 See chapter 6 in the C# language specification for more information on user-defined conversions.  
  
 The following sample generates CS0554:  
  
```  
// CS0554.cs  
namespace x  
{  
   public class ii  
   {  
      // delete the conversion routine to resolve CS0554  
      public static implicit operator ii(a aa) // CS0554  
      {  
         return new ii();  
      }  
   }  
  
   public class a : ii  
   {  
      public static void Main()  
      {  
      }  
   }  
}  
```