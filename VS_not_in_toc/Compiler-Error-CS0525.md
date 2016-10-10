---
title: "Compiler Error CS0525"
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
ms.assetid: fcecfd4f-221f-41e6-a95c-1685be78926e
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
# Compiler Error CS0525
Interfaces cannot contain fields  
  
 An [interface](../Topic/interface%20\(C%23%20Reference\).md) can contain methods and properties but not fields.  
  
 The following sample generates CS0525:  
  
```  
// CS0525.cs  
namespace x  
{  
   public interface clx  
   {  
      public int i;   // CS0525  
   }  
}  
```