---
title: "Compiler Error CS1660"
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
ms.assetid: ae7fede3-471b-4e20-97a7-b80fdc2bb080
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
# Compiler Error CS1660
Cannot convert anonymous method block to type 'type' because it is not a delegate type  
  
 This error occurs if you try to assign or otherwise convert an anonymous method block to a type which is not a delegate type.  
  
 The following sample generates CS1660:  
  
```  
// CS1660.cs  
delegate int MyDelegate();  
class C {  
   static void Main()  
   {  
     int i = delegate { return 1; };  // CS1660  
     // Try this instead:  
     // MyDelegate myDelegate = delegate { return 1; };  
     // int i = myDelegate();  
   }  
}  
```