---
title: "Compiler Error CS0140"
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
ms.assetid: 61787b8a-7b69-41c1-8ee3-87f619698594
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
# Compiler Error CS0140
The label 'label' is a duplicate  
  
 A label with the same name appeared twice. For more information, see [goto](../Topic/goto%20\(C%23%20Reference\).md).  
  
 The following sample generates CS0140:  
  
```  
// CS0140.cs  
namespace MyNamespace  
{  
   public class MyClass  
   {  
      public static void Main()  
      {  
         label1: int i = 0;  
         label1: int j = 0;   // CS0140, comment this line to resolve  
         goto label1;  
      }  
   }  
}  
```