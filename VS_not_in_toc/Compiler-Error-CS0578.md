---
title: "Compiler Error CS0578"
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
ms.assetid: fbc5c884-e358-48f1-aeac-5ec8fd9f0c40
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
# Compiler Error CS0578
The Conditional attribute is not valid on 'function' because its return type is not void  
  
 <xref:System.Diagnostics.ConditionalAttribute?qualifyHint=False> cannot be applied to a method that has a return type other than `void`. The reason for this is that any other return type for a method may be needed by another part of your program.  
  
## Example  
 The following sample generates CS0578. To resolve this error, you must either delete <xref:System.Diagnostics.ConditionalAttribute?qualifyHint=False>, or you must change the return value of the method to `void`.  
  
```  
// CS0578.cs  
// compile with: /target:library  
public class MyClass  
{  
   [System.Diagnostics.ConditionalAttribute("a")]   // CS0578  
   public int TestMethod()  
   {  
      return 0;  
   }  
}  
```